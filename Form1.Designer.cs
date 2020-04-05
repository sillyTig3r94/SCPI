namespace SCPI_Example
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_QueryDCVolt = new System.Windows.Forms.Button();
            this.txt_Query = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bt_QueryAC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_rangeVoltage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_resolutionVoltage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_LimitHighDC = new System.Windows.Forms.TextBox();
            this.txb_LimitLowDC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_SetLimit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_Output = new System.Windows.Forms.TextBox();
            this.bt_enableStats = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer_Statistic = new System.Windows.Forms.Timer(this.components);
            this.bt_disableStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_QueryDCVolt
            // 
            this.bt_QueryDCVolt.Location = new System.Drawing.Point(90, 197);
            this.bt_QueryDCVolt.Name = "bt_QueryDCVolt";
            this.bt_QueryDCVolt.Size = new System.Drawing.Size(67, 43);
            this.bt_QueryDCVolt.TabIndex = 0;
            this.bt_QueryDCVolt.Text = "Query DC Voltage";
            this.bt_QueryDCVolt.UseVisualStyleBackColor = true;
            this.bt_QueryDCVolt.Click += new System.EventHandler(this.bt_QueryDCVolt_Click);
            // 
            // txt_Query
            // 
            this.txt_Query.Location = new System.Drawing.Point(90, 267);
            this.txt_Query.Multiline = true;
            this.txt_Query.Name = "txt_Query";
            this.txt_Query.Size = new System.Drawing.Size(150, 48);
            this.txt_Query.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bt_QueryAC
            // 
            this.bt_QueryAC.Location = new System.Drawing.Point(173, 197);
            this.bt_QueryAC.Name = "bt_QueryAC";
            this.bt_QueryAC.Size = new System.Drawing.Size(67, 43);
            this.bt_QueryAC.TabIndex = 3;
            this.bt_QueryAC.Text = "Query AC Voltage";
            this.bt_QueryAC.UseVisualStyleBackColor = true;
            this.bt_QueryAC.Click += new System.EventHandler(this.bt_QueryAC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Response";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 34);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Device Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Range";
            // 
            // txb_rangeVoltage
            // 
            this.txb_rangeVoltage.Location = new System.Drawing.Point(323, 150);
            this.txb_rangeVoltage.Multiline = true;
            this.txb_rangeVoltage.Name = "txb_rangeVoltage";
            this.txb_rangeVoltage.Size = new System.Drawing.Size(53, 20);
            this.txb_rangeVoltage.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resolution";
            // 
            // txb_resolutionVoltage
            // 
            this.txb_resolutionVoltage.Location = new System.Drawing.Point(474, 150);
            this.txb_resolutionVoltage.Multiline = true;
            this.txb_resolutionVoltage.Name = "txb_resolutionVoltage";
            this.txb_resolutionVoltage.Size = new System.Drawing.Size(53, 20);
            this.txb_resolutionVoltage.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Limit Upper";
            // 
            // txb_LimitHighDC
            // 
            this.txb_LimitHighDC.Location = new System.Drawing.Point(387, 220);
            this.txb_LimitHighDC.Multiline = true;
            this.txb_LimitHighDC.Name = "txb_LimitHighDC";
            this.txb_LimitHighDC.Size = new System.Drawing.Size(81, 23);
            this.txb_LimitHighDC.TabIndex = 12;
            // 
            // txb_LimitLowDC
            // 
            this.txb_LimitLowDC.Location = new System.Drawing.Point(493, 220);
            this.txb_LimitLowDC.Multiline = true;
            this.txb_LimitLowDC.Name = "txb_LimitLowDC";
            this.txb_LimitLowDC.Size = new System.Drawing.Size(74, 23);
            this.txb_LimitLowDC.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Limit Lower";
            // 
            // bt_SetLimit
            // 
            this.bt_SetLimit.Location = new System.Drawing.Point(301, 220);
            this.bt_SetLimit.Name = "bt_SetLimit";
            this.bt_SetLimit.Size = new System.Drawing.Size(75, 23);
            this.bt_SetLimit.TabIndex = 15;
            this.bt_SetLimit.Text = "Set Limit";
            this.bt_SetLimit.UseVisualStyleBackColor = true;
            this.bt_SetLimit.Click += new System.EventHandler(this.bt_SetLimit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Statistic";
            // 
            // txb_Output
            // 
            this.txb_Output.Location = new System.Drawing.Point(332, 308);
            this.txb_Output.Multiline = true;
            this.txb_Output.Name = "txb_Output";
            this.txb_Output.Size = new System.Drawing.Size(595, 130);
            this.txb_Output.TabIndex = 17;
            // 
            // bt_enableStats
            // 
            this.bt_enableStats.Location = new System.Drawing.Point(264, 329);
            this.bt_enableStats.Name = "bt_enableStats";
            this.bt_enableStats.Size = new System.Drawing.Size(62, 23);
            this.bt_enableStats.TabIndex = 18;
            this.bt_enableStats.Text = "Enable";
            this.bt_enableStats.UseVisualStyleBackColor = true;
            this.bt_enableStats.Click += new System.EventHandler(this.bt_StatEnable_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(944, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(491, 385);
            this.textBox2.TabIndex = 19;
            // 
            // timer_Statistic
            // 
            this.timer_Statistic.Interval = 1000;
            this.timer_Statistic.Tick += new System.EventHandler(this.timer_Statistic_Tick);
            // 
            // bt_disableStats
            // 
            this.bt_disableStats.Location = new System.Drawing.Point(264, 358);
            this.bt_disableStats.Name = "bt_disableStats";
            this.bt_disableStats.Size = new System.Drawing.Size(62, 23);
            this.bt_disableStats.TabIndex = 20;
            this.bt_disableStats.Text = "Disable";
            this.bt_disableStats.UseVisualStyleBackColor = true;
            this.bt_disableStats.Click += new System.EventHandler(this.bt_disableStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 450);
            this.Controls.Add(this.bt_disableStats);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bt_enableStats);
            this.Controls.Add(this.txb_Output);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_SetLimit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_LimitLowDC);
            this.Controls.Add(this.txb_LimitHighDC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_resolutionVoltage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_rangeVoltage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_QueryAC);
            this.Controls.Add(this.txt_Query);
            this.Controls.Add(this.bt_QueryDCVolt);
            this.Name = "Form1";
            this.Text = "34410A Digit Multimeter Control Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_QueryDCVolt;
        private System.Windows.Forms.TextBox txt_Query;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bt_QueryAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_rangeVoltage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_resolutionVoltage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_LimitHighDC;
        private System.Windows.Forms.TextBox txb_LimitLowDC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_SetLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_Output;
        private System.Windows.Forms.Button bt_enableStats;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer_Statistic;
        private System.Windows.Forms.Button bt_disableStats;
    }
}

