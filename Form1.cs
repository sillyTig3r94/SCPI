using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ivi.Visa.Interop;

namespace SCPI_Example
{
    /* USB Communication */
    public partial class Form1 : Form
    {
        //private Ivi.Visa.Interop.FormattedIO488 ioUSB = new FormattedIO488();
        //private ResourceManager grm = new ResourceManager();
        private ResourceManager manager = new ResourceManager();
        private FormattedIO488 connection = new FormattedIO488();
        //const string resourceString = "USB0::2391::1543::MY47024772::0::INSTR";   //Device ID
        //GPIB" + cboGpibPort.Text + "::" + cboGpibAddr.Text + "::INSTR", AccessMode.NO_LOCK, 7500, "");
        //const string resourceString = "GPIB0::4::INSTR";
        const string resourceString = "USB0::0x0957::0x0607::MY47024772::0::INSTR";
        CancellationTokenSource source = new CancellationTokenSource();

        /* define FSM */
        const int RST = 1;
        const int TRIG_SOURCE = 2;
        const int TRIG_COUNT = 3;
        const int CALC_ON = 4;
        const int INIT_IMM = 5;
        const int CALC_FUNC = 6;
        const int CALC_CLR = 7;
        const int QUERY_COUNT = 8;
        const int QUERY_MIN = 9;
        const int QUERY_MAX = 10;
        const int QUERY_AVG = 11;

        public int state = RST; //initial state
        public int next_state = RST; //intial state
        

        public Form1()
        {
            InitializeComponent();

            connection.IO = (IMessage)manager.Open(resourceString, AccessMode.NO_LOCK, 0, "");  //accessing device\
            connection.IO.Clear();

        }

        private double ConvertExptoDouble(string myString)
        {
            double myDouble = 0.0;

            try
            {
                Double.TryParse(myString.Substring(1), System.Globalization.NumberStyles.Float, null, out myDouble);
            }
            catch
            {
                MessageBox.Show("Invalid result format.");
            }

            return myDouble;
        }

        private void WriteOutput(string myString)
        {
            ConvertExptoDouble(myString);
            switch(state)
            {
                case QUERY_AVG:
                    txb_Output.Text += "Average: " + String.Format("{0:0.###}", ConvertExptoDouble(myString)) + Environment.NewLine;
                    break;
                case QUERY_COUNT:
                    txb_Output.Text += "Count: " + String.Format("{0:0.###}", ConvertExptoDouble(myString)) + "  ";
                    break;
                case QUERY_MAX:
                    txb_Output.Text += "Max: " + String.Format("{0:0.###}", ConvertExptoDouble(myString)) + "  ";
                    break;
                case QUERY_MIN:
                    txb_Output.Text += "Min: " + String.Format("{0:0.###}", ConvertExptoDouble(myString)) + "  ";
                    break;
                default:    //never get here but just in case
                    txb_Output.Text += "Wrong way. Never get here buddy" + Environment.NewLine;
                    break;
            }

        }

        /* Example to Query Resistance */
        private void bt_QueryDCVolt_Click(object sender, EventArgs e)
        {
            string result = "Invalid Measurement";

            string command = "MEAS:VOLT:DC?";

            Double myDCVoltage = 0.0;

            string signness;
            try
            {
                if (String.IsNullOrEmpty(txb_rangeVoltage.Text))
                    command = command + " " + txb_rangeVoltage;
                if (String.IsNullOrEmpty(txb_resolutionVoltage.Text))
                    command = command + "," + txb_resolutionVoltage;

                connection.WriteString("MEAS:VOLT:DC? " + txb_rangeVoltage.Text, true);    //Command - Refer document for more detail 

                result = connection.ReadString();

                signness = result.Substring(0,1);

            }
            catch
            {
                return;
            }

            myDCVoltage = ConvertExptoDouble(result);


            txt_Query.Text = signness + String.Format("{0:0.###}", myDCVoltage) + "[VDC]";

        }

        /* Example to Query Capacitance */
        private void bt_QueryAC_Click(object sender, EventArgs e)
        {
            string result = "Invalid Measurement";
            try
            {
                connection.WriteString("MEASure:CAPacitance?", true);
                result = connection.ReadString();
            }
            catch
            {
                return;
            }
            
            txt_Query.Text = result;
        }

        private void bt_SetLimit_Click(object sender, EventArgs e)
        {
            string result = "Invalid Command";
            string command = "CALCulate:STATe?";
            try
            {
                connection.WriteString(command, true);    //Command - Refer document for more detail 
                result = connection.ReadString();
            }
            catch
            {
                return;
            }

            txt_Query.Text = result;

        }

        private void bt_StatEnable_Click(object sender, EventArgs e)
        {
            timer_Statistic.Enabled = true;
        }

        private void timer_Statistic_Tick(object sender, EventArgs e)
        {
            string result = "Invalid Command";
            string command = "";

            state = next_state;

            try
            {
                switch (state)
                {
                    case RST: // Turn off
                        command = "*RST";
                        connection.WriteString(command, true);
                        next_state = TRIG_SOURCE;
                        textBox2.Text += command + Environment.NewLine;
                        break;
                    case TRIG_SOURCE: //Trigger
                        command = "TRIG:SOURCE IMM";
                        next_state = TRIG_COUNT;
                        textBox2.Text += command + Environment.NewLine;
                        break;
                    case TRIG_COUNT: //Initial
                        command = "TRIG:COUNT -1";
                        connection.WriteString(command, true);
                        next_state = CALC_ON;
                        textBox2.Text += command + Environment.NewLine;
                        break;
                    case CALC_ON:
                        command = "CALC ON";
                        connection.WriteString(command, true);
                        next_state = CALC_FUNC;
                        textBox2.Text += command + Environment.NewLine;
                        break;
                    case CALC_FUNC:
                        command = "CALCulate:FUNCtion AVERage";
                        connection.WriteString(command, true);
                        next_state = CALC_CLR;
                        textBox2.Text += command + Environment.NewLine;
                        break;
                    case CALC_CLR:
                        command = "CALCulate:AVERage:CLEar";
                        connection.WriteString(command, true);
                        next_state = INIT_IMM;
                        textBox2.Text += command + Environment.NewLine;
                        break;
                    case INIT_IMM:
                        command = "INITiate:IMM";
                        connection.WriteString(command, true);
                        next_state = QUERY_COUNT;
                        textBox2.Text += command + Environment.NewLine;
                        break;
                    case QUERY_COUNT: //get average value
                        command = "CALCulate:AVERage:COUNT?";
                        connection.WriteString(command, true);
                        result = connection.ReadString();
                        WriteOutput(result);
                        next_state = QUERY_MAX;
                        textBox2.Text += command + Environment.NewLine;

                        timer_Statistic.Interval = 10;

                        break;
                    case QUERY_MAX: //get average value
                        command = "CALCulate:AVERage:MAX?";
                        connection.WriteString(command, true);
                        result = connection.ReadString();
                        WriteOutput(result);
                        next_state = QUERY_MIN;
                        textBox2.Text += command + Environment.NewLine;
                        break;
                    case QUERY_MIN: //get average value
                        command = "CALCulate:AVERage:MIN?";
                        connection.WriteString(command, true);
                        result = connection.ReadString();
                        WriteOutput(result);
                        next_state = QUERY_AVG;
                        textBox2.Text += command + Environment.NewLine;
                        break;
                    case QUERY_AVG: //get average value
                        command = "CALCulate:AVERage:AVERage?";
                        connection.WriteString(command, true);
                        result = connection.ReadString();
                        WriteOutput(result);
                        next_state = QUERY_COUNT;
                        textBox2.Text += command + Environment.NewLine;

                        timer_Statistic.Interval = 5000;
                        break;
                    default:    //never get here but just in case
                        state = 0;
                        break;

                }

            }
            catch
            {
                return;
            }

            txt_Query.Text = result;
        }

        private void bt_disableStats_Click(object sender, EventArgs e)
        {
            string command = "";

            command = "ABORT";
            connection.WriteString(command, true);

            timer_Statistic.Enabled = false;

            state = 1;
        }
    }
}
