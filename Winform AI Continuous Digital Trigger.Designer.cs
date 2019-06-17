namespace SeeSharpExample.JY.JYPCI69816H
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_SampleRate = new System.Windows.Forms.Label();
            this.label_Channel = new System.Windows.Forms.Label();
            this.label_RangeLow = new System.Windows.Forms.Label();
            this.label_RangeHigh = new System.Windows.Forms.Label();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_inputLowLimit = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_inputHighLimit = new System.Windows.Forms.NumericUpDown();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_boardNumber = new System.Windows.Forms.ComboBox();
            this.groupBox_genParam = new System.Windows.Forms.GroupBox();
            this.numericUpDown_samples = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_inputImpedance = new System.Windows.Forms.ComboBox();
            this.comboBox_channelNo = new System.Windows.Forms.ComboBox();
            this.label_Impedance = new System.Windows.Forms.Label();
            this.groupBox_trigParam = new System.Windows.Forms.GroupBox();
            this.numericUpDown_triggerDelay = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_triggerEdge = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_triggerSource = new System.Windows.Forms.ComboBox();
            this.easyChart1 = new SeeSharpTools.JY.GUI.EasyChart();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputLowLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputHighLimit)).BeginInit();
            this.groupBox_genParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).BeginInit();
            this.groupBox_trigParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_triggerDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SampleRate
            // 
            this.label_SampleRate.AutoSize = true;
            this.label_SampleRate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SampleRate.Location = new System.Drawing.Point(5, 80);
            this.label_SampleRate.Name = "label_SampleRate";
            this.label_SampleRate.Size = new System.Drawing.Size(98, 14);
            this.label_SampleRate.TabIndex = 1;
            this.label_SampleRate.Text = "采样率(Sa/s) ";
            // 
            // label_Channel
            // 
            this.label_Channel.AutoSize = true;
            this.label_Channel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Channel.Location = new System.Drawing.Point(6, 51);
            this.label_Channel.Name = "label_Channel";
            this.label_Channel.Size = new System.Drawing.Size(49, 14);
            this.label_Channel.TabIndex = 2;
            this.label_Channel.Text = "通道号";
            // 
            // label_RangeLow
            // 
            this.label_RangeLow.AutoSize = true;
            this.label_RangeLow.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_RangeLow.Location = new System.Drawing.Point(6, 159);
            this.label_RangeLow.Name = "label_RangeLow";
            this.label_RangeLow.Size = new System.Drawing.Size(112, 14);
            this.label_RangeLow.TabIndex = 3;
            this.label_RangeLow.Text = "最小输入限制(V)";
            // 
            // label_RangeHigh
            // 
            this.label_RangeHigh.AutoSize = true;
            this.label_RangeHigh.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_RangeHigh.Location = new System.Drawing.Point(6, 133);
            this.label_RangeHigh.Name = "label_RangeHigh";
            this.label_RangeHigh.Size = new System.Drawing.Size(112, 14);
            this.label_RangeHigh.TabIndex = 4;
            this.label_RangeHigh.Text = "最大输入限制(V)";
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(123, 74);
            this.numericUpDown_sampleRate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Name = "numericUpDown_sampleRate";
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(105, 21);
            this.numericUpDown_sampleRate.TabIndex = 5;
            this.numericUpDown_sampleRate.Tag = "ParaConfig";
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // numericUpDown_inputLowLimit
            // 
            this.numericUpDown_inputLowLimit.DecimalPlaces = 1;
            this.numericUpDown_inputLowLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_inputLowLimit.Location = new System.Drawing.Point(124, 155);
            this.numericUpDown_inputLowLimit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_inputLowLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_inputLowLimit.Name = "numericUpDown_inputLowLimit";
            this.numericUpDown_inputLowLimit.Size = new System.Drawing.Size(105, 21);
            this.numericUpDown_inputLowLimit.TabIndex = 7;
            this.numericUpDown_inputLowLimit.Tag = "ParaConfig";
            this.numericUpDown_inputLowLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // numericUpDown_inputHighLimit
            // 
            this.numericUpDown_inputHighLimit.DecimalPlaces = 1;
            this.numericUpDown_inputHighLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_inputHighLimit.Location = new System.Drawing.Point(124, 128);
            this.numericUpDown_inputHighLimit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_inputHighLimit.Name = "numericUpDown_inputHighLimit";
            this.numericUpDown_inputHighLimit.Size = new System.Drawing.Size(105, 21);
            this.numericUpDown_inputHighLimit.TabIndex = 8;
            this.numericUpDown_inputHighLimit.Tag = "ParaConfig";
            this.numericUpDown_inputHighLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(704, 463);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(66, 30);
            this.button_start.TabIndex = 9;
            this.button_start.Tag = "ParaConfig";
            this.button_start.Text = "启动";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(790, 463);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(66, 30);
            this.button_stop.TabIndex = 10;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 64;
            this.label7.Text = "板卡号 ";
            // 
            // comboBox_boardNumber
            // 
            this.comboBox_boardNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_boardNumber.FormattingEnabled = true;
            this.comboBox_boardNumber.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_boardNumber.Location = new System.Drawing.Point(123, 19);
            this.comboBox_boardNumber.Name = "comboBox_boardNumber";
            this.comboBox_boardNumber.Size = new System.Drawing.Size(105, 20);
            this.comboBox_boardNumber.TabIndex = 63;
            this.comboBox_boardNumber.Tag = "ParaConfig";
            // 
            // groupBox_genParam
            // 
            this.groupBox_genParam.Controls.Add(this.numericUpDown_samples);
            this.groupBox_genParam.Controls.Add(this.label1);
            this.groupBox_genParam.Controls.Add(this.comboBox_inputImpedance);
            this.groupBox_genParam.Controls.Add(this.comboBox_channelNo);
            this.groupBox_genParam.Controls.Add(this.label_Impedance);
            this.groupBox_genParam.Controls.Add(this.comboBox_boardNumber);
            this.groupBox_genParam.Controls.Add(this.label7);
            this.groupBox_genParam.Controls.Add(this.label_RangeLow);
            this.groupBox_genParam.Controls.Add(this.label_SampleRate);
            this.groupBox_genParam.Controls.Add(this.label_Channel);
            this.groupBox_genParam.Controls.Add(this.numericUpDown_inputLowLimit);
            this.groupBox_genParam.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_genParam.Controls.Add(this.numericUpDown_inputHighLimit);
            this.groupBox_genParam.Controls.Add(this.label_RangeHigh);
            this.groupBox_genParam.Location = new System.Drawing.Point(704, 94);
            this.groupBox_genParam.Name = "groupBox_genParam";
            this.groupBox_genParam.Size = new System.Drawing.Size(243, 213);
            this.groupBox_genParam.TabIndex = 65;
            this.groupBox_genParam.TabStop = false;
            this.groupBox_genParam.Text = "基本参数配置";
            // 
            // numericUpDown_samples
            // 
            this.numericUpDown_samples.Location = new System.Drawing.Point(123, 101);
            this.numericUpDown_samples.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_samples.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_samples.Name = "numericUpDown_samples";
            this.numericUpDown_samples.Size = new System.Drawing.Size(105, 21);
            this.numericUpDown_samples.TabIndex = 77;
            this.numericUpDown_samples.Tag = "ParaConfig";
            this.numericUpDown_samples.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 76;
            this.label1.Text = "采样点数";
            // 
            // comboBox_inputImpedance
            // 
            this.comboBox_inputImpedance.FormattingEnabled = true;
            this.comboBox_inputImpedance.Location = new System.Drawing.Point(123, 182);
            this.comboBox_inputImpedance.Name = "comboBox_inputImpedance";
            this.comboBox_inputImpedance.Size = new System.Drawing.Size(105, 20);
            this.comboBox_inputImpedance.TabIndex = 75;
            // 
            // comboBox_channelNo
            // 
            this.comboBox_channelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_channelNo.FormattingEnabled = true;
            this.comboBox_channelNo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_channelNo.Location = new System.Drawing.Point(123, 45);
            this.comboBox_channelNo.Name = "comboBox_channelNo";
            this.comboBox_channelNo.Size = new System.Drawing.Size(105, 20);
            this.comboBox_channelNo.TabIndex = 67;
            this.comboBox_channelNo.Tag = "ParaConfig";
            // 
            // label_Impedance
            // 
            this.label_Impedance.AutoSize = true;
            this.label_Impedance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Impedance.Location = new System.Drawing.Point(7, 186);
            this.label_Impedance.Name = "label_Impedance";
            this.label_Impedance.Size = new System.Drawing.Size(63, 14);
            this.label_Impedance.TabIndex = 73;
            this.label_Impedance.Text = "输入阻抗";
            // 
            // groupBox_trigParam
            // 
            this.groupBox_trigParam.Controls.Add(this.numericUpDown_triggerDelay);
            this.groupBox_trigParam.Controls.Add(this.label9);
            this.groupBox_trigParam.Controls.Add(this.label6);
            this.groupBox_trigParam.Controls.Add(this.comboBox_triggerEdge);
            this.groupBox_trigParam.Controls.Add(this.label8);
            this.groupBox_trigParam.Controls.Add(this.comboBox_triggerSource);
            this.groupBox_trigParam.Location = new System.Drawing.Point(704, 313);
            this.groupBox_trigParam.Name = "groupBox_trigParam";
            this.groupBox_trigParam.Size = new System.Drawing.Size(243, 115);
            this.groupBox_trigParam.TabIndex = 71;
            this.groupBox_trigParam.TabStop = false;
            this.groupBox_trigParam.Text = "触发参数设置";
            // 
            // numericUpDown_triggerDelay
            // 
            this.numericUpDown_triggerDelay.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_triggerDelay.Location = new System.Drawing.Point(123, 78);
            this.numericUpDown_triggerDelay.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_triggerDelay.Name = "numericUpDown_triggerDelay";
            this.numericUpDown_triggerDelay.Size = new System.Drawing.Size(105, 21);
            this.numericUpDown_triggerDelay.TabIndex = 72;
            this.numericUpDown_triggerDelay.Tag = "ParaConfig";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(5, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 14);
            this.label9.TabIndex = 71;
            this.label9.Text = "延迟时间（us）";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(5, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 69;
            this.label6.Text = "触发边沿";
            // 
            // comboBox_triggerEdge
            // 
            this.comboBox_triggerEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triggerEdge.FormattingEnabled = true;
            this.comboBox_triggerEdge.Location = new System.Drawing.Point(123, 47);
            this.comboBox_triggerEdge.Name = "comboBox_triggerEdge";
            this.comboBox_triggerEdge.Size = new System.Drawing.Size(105, 20);
            this.comboBox_triggerEdge.TabIndex = 70;
            this.comboBox_triggerEdge.Tag = "ParaConfig";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(5, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 68;
            this.label8.Text = "触发源";
            // 
            // comboBox_triggerSource
            // 
            this.comboBox_triggerSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triggerSource.FormattingEnabled = true;
            this.comboBox_triggerSource.Location = new System.Drawing.Point(123, 20);
            this.comboBox_triggerSource.Name = "comboBox_triggerSource";
            this.comboBox_triggerSource.Size = new System.Drawing.Size(105, 20);
            this.comboBox_triggerSource.TabIndex = 68;
            this.comboBox_triggerSource.Tag = "ParaConfig";
            // 
            // easyChart1
            // 
            this.easyChart1.LegendVisible = true;
            this.easyChart1.Location = new System.Drawing.Point(31, 94);
            this.easyChart1.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart1.Name = "easyChart1";
            this.easyChart1.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart1.SeriesNames = new string[] {
        "Series1",
        "Series2",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.easyChart1.Size = new System.Drawing.Size(653, 458);
            this.easyChart1.TabIndex = 0;
            this.easyChart1.XAxisLogarithmic = false;
            this.easyChart1.YAxisLogarithmic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 31);
            this.label2.TabIndex = 82;
            this.label2.Text = "JYPCI69816H单通道连续采集（数字触发）";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(959, 80);
            this.splitter1.TabIndex = 83;
            this.splitter1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox_trigParam);
            this.Controls.Add(this.groupBox_genParam);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.easyChart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JYPCI69816H单通道连续采集（数字触发）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputLowLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inputHighLimit)).EndInit();
            this.groupBox_genParam.ResumeLayout(false);
            this.groupBox_genParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_samples)).EndInit();
            this.groupBox_trigParam.ResumeLayout(false);
            this.groupBox_trigParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_triggerDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeeSharpTools.JY.GUI.EasyChart easyChart1;
        private System.Windows.Forms.Label label_SampleRate;
        private System.Windows.Forms.Label label_Channel;
        private System.Windows.Forms.Label label_RangeLow;
        private System.Windows.Forms.Label label_RangeHigh;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_inputLowLimit;
        private System.Windows.Forms.NumericUpDown numericUpDown_inputHighLimit;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_boardNumber;
        private System.Windows.Forms.GroupBox groupBox_genParam;
        private System.Windows.Forms.ComboBox comboBox_channelNo;
        private System.Windows.Forms.GroupBox groupBox_trigParam;
        private System.Windows.Forms.NumericUpDown numericUpDown_triggerDelay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_triggerEdge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_triggerSource;
        private System.Windows.Forms.ComboBox comboBox_inputImpedance;
        private System.Windows.Forms.Label label_Impedance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown numericUpDown_samples;
        private System.Windows.Forms.Label label1;
    }
}

