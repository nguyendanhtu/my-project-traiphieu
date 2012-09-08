namespace IPChart
{
    partial class frmPieChart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.checkBoxGroup = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveZeroValue = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEdgeType = new System.Windows.Forms.ComboBox();
            this.m_numericUpDownAlpha = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownEdgeLineWidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFitChart = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPieHeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDownBottomMargin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTopMargin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRightMargin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLeftMargin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonShadowStyleGradual = new System.Windows.Forms.RadioButton();
            this.radioButtonShadowStyleUniform = new System.Windows.Forms.RadioButton();
            this.radioButtonShadowStyleNone = new System.Windows.Forms.RadioButton();
            this.m_buttonPrint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pieChartControl = new System.Drawing.PieChart.PieChartControl();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_numericUpDownAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdgeLineWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPieHeight)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottomMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRightMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeftMargin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 511);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.numericUpDownThreshold);
            this.groupBox5.Controls.Add(this.checkBoxGroup);
            this.groupBox5.Controls.Add(this.checkBoxRemoveZeroValue);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 397);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 100);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Location = new System.Drawing.Point(25, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Threshold";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownThreshold.DecimalPlaces = 2;
            this.numericUpDownThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownThreshold.Location = new System.Drawing.Point(97, 68);
            this.numericUpDownThreshold.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThreshold.Name = "numericUpDownThreshold";
            this.numericUpDownThreshold.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownThreshold.TabIndex = 21;
            this.numericUpDownThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownThreshold.Value = new decimal(new int[] {
            7,
            0,
            0,
            131072});
            this.numericUpDownThreshold.ValueChanged += new System.EventHandler(this.numericUpDownThreshold_ValueChanged);
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.AutoSize = true;
            this.checkBoxGroup.Checked = true;
            this.checkBoxGroup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGroup.Location = new System.Drawing.Point(16, 43);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(55, 17);
            this.checkBoxGroup.TabIndex = 1;
            this.checkBoxGroup.Text = "Group";
            this.checkBoxGroup.UseVisualStyleBackColor = true;
            this.checkBoxGroup.CheckedChanged += new System.EventHandler(this.checkBoxGroup_CheckedChanged);
            // 
            // checkBoxRemoveZeroValue
            // 
            this.checkBoxRemoveZeroValue.AutoSize = true;
            this.checkBoxRemoveZeroValue.Checked = true;
            this.checkBoxRemoveZeroValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemoveZeroValue.Location = new System.Drawing.Point(16, 20);
            this.checkBoxRemoveZeroValue.Name = "checkBoxRemoveZeroValue";
            this.checkBoxRemoveZeroValue.Size = new System.Drawing.Size(118, 17);
            this.checkBoxRemoveZeroValue.TabIndex = 0;
            this.checkBoxRemoveZeroValue.Text = "Remove zero value";
            this.checkBoxRemoveZeroValue.UseVisualStyleBackColor = true;
            this.checkBoxRemoveZeroValue.CheckedChanged += new System.EventHandler(this.checkBoxRemoveZeroValue_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBoxEdgeType);
            this.groupBox3.Controls.Add(this.m_numericUpDownAlpha);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.numericUpDownEdgeLineWidth);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 128);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edge";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "&Edge color:";
            // 
            // comboBoxEdgeType
            // 
            this.comboBoxEdgeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxEdgeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdgeType.Location = new System.Drawing.Point(12, 38);
            this.comboBoxEdgeType.Name = "comboBoxEdgeType";
            this.comboBoxEdgeType.Size = new System.Drawing.Size(176, 21);
            this.comboBoxEdgeType.TabIndex = 24;
            this.comboBoxEdgeType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdgeType_SelectedIndexChanged);
            // 
            // m_numericUpDownAlpha
            // 
            this.m_numericUpDownAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_numericUpDownAlpha.Location = new System.Drawing.Point(80, 96);
            this.m_numericUpDownAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.m_numericUpDownAlpha.Name = "m_numericUpDownAlpha";
            this.m_numericUpDownAlpha.Size = new System.Drawing.Size(48, 20);
            this.m_numericUpDownAlpha.TabIndex = 28;
            this.m_numericUpDownAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m_numericUpDownAlpha.Value = new decimal(new int[] {
            122,
            0,
            0,
            0});
            this.m_numericUpDownAlpha.ValueChanged += new System.EventHandler(this.m_numericUpDownAlpha_ValueChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.Location = new System.Drawing.Point(8, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Edge &width:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.Location = new System.Drawing.Point(8, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "&Alpha:";
            // 
            // numericUpDownEdgeLineWidth
            // 
            this.numericUpDownEdgeLineWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownEdgeLineWidth.DecimalPlaces = 1;
            this.numericUpDownEdgeLineWidth.Location = new System.Drawing.Point(80, 68);
            this.numericUpDownEdgeLineWidth.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEdgeLineWidth.Name = "numericUpDownEdgeLineWidth";
            this.numericUpDownEdgeLineWidth.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownEdgeLineWidth.TabIndex = 26;
            this.numericUpDownEdgeLineWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownEdgeLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEdgeLineWidth.ValueChanged += new System.EventHandler(this.numericUpDownEdgeLineWidth_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxFitChart);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDownAngle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownPieHeight);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 115);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape";
            // 
            // checkBoxFitChart
            // 
            this.checkBoxFitChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxFitChart.Location = new System.Drawing.Point(9, 30);
            this.checkBoxFitChart.Name = "checkBoxFitChart";
            this.checkBoxFitChart.Size = new System.Drawing.Size(136, 16);
            this.checkBoxFitChart.TabIndex = 17;
            this.checkBoxFitChart.Text = "&Fit chart to panel";
            this.checkBoxFitChart.CheckedChanged += new System.EventHandler(this.checkBoxFitChart_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pie &height:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAngle.Location = new System.Drawing.Point(96, 86);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownAngle.TabIndex = 21;
            this.numericUpDownAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAngle.Value = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDownAngle.ValueChanged += new System.EventHandler(this.numericUpDownAngle_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(24, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Initial angle:";
            // 
            // numericUpDownPieHeight
            // 
            this.numericUpDownPieHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPieHeight.DecimalPlaces = 2;
            this.numericUpDownPieHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownPieHeight.Location = new System.Drawing.Point(96, 56);
            this.numericUpDownPieHeight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownPieHeight.Name = "numericUpDownPieHeight";
            this.numericUpDownPieHeight.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownPieHeight.TabIndex = 19;
            this.numericUpDownPieHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPieHeight.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownPieHeight.ValueChanged += new System.EventHandler(this.numericUpDownPieHeight_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownBottomMargin);
            this.groupBox4.Controls.Add(this.numericUpDownTopMargin);
            this.groupBox4.Controls.Add(this.numericUpDownRightMargin);
            this.groupBox4.Controls.Add(this.numericUpDownLeftMargin);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 72);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "&Margins";
            // 
            // numericUpDownBottomMargin
            // 
            this.numericUpDownBottomMargin.Location = new System.Drawing.Point(142, 42);
            this.numericUpDownBottomMargin.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownBottomMargin.Name = "numericUpDownBottomMargin";
            this.numericUpDownBottomMargin.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownBottomMargin.TabIndex = 7;
            this.numericUpDownBottomMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownBottomMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBottomMargin.ValueChanged += new System.EventHandler(this.numericUpDownBottomMargin_ValueChanged);
            // 
            // numericUpDownTopMargin
            // 
            this.numericUpDownTopMargin.Location = new System.Drawing.Point(142, 18);
            this.numericUpDownTopMargin.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownTopMargin.Name = "numericUpDownTopMargin";
            this.numericUpDownTopMargin.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownTopMargin.TabIndex = 5;
            this.numericUpDownTopMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTopMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTopMargin.ValueChanged += new System.EventHandler(this.numericUpDownTopMargin_ValueChanged);
            // 
            // numericUpDownRightMargin
            // 
            this.numericUpDownRightMargin.Location = new System.Drawing.Point(40, 44);
            this.numericUpDownRightMargin.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownRightMargin.Name = "numericUpDownRightMargin";
            this.numericUpDownRightMargin.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownRightMargin.TabIndex = 3;
            this.numericUpDownRightMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownRightMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRightMargin.ValueChanged += new System.EventHandler(this.numericUpDownRightMargin_ValueChanged);
            // 
            // numericUpDownLeftMargin
            // 
            this.numericUpDownLeftMargin.Location = new System.Drawing.Point(40, 20);
            this.numericUpDownLeftMargin.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLeftMargin.Name = "numericUpDownLeftMargin";
            this.numericUpDownLeftMargin.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownLeftMargin.TabIndex = 1;
            this.numericUpDownLeftMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownLeftMargin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLeftMargin.ValueChanged += new System.EventHandler(this.numericUpDownLeftMargin_ValueChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(96, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "&Bottom:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(96, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "&Top:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "&Right:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Left:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonShadowStyleGradual);
            this.groupBox1.Controls.Add(this.radioButtonShadowStyleUniform);
            this.groupBox1.Controls.Add(this.radioButtonShadowStyleNone);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 82);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shadow style";
            // 
            // radioButtonShadowStyleGradual
            // 
            this.radioButtonShadowStyleGradual.Checked = true;
            this.radioButtonShadowStyleGradual.Location = new System.Drawing.Point(16, 58);
            this.radioButtonShadowStyleGradual.Name = "radioButtonShadowStyleGradual";
            this.radioButtonShadowStyleGradual.Size = new System.Drawing.Size(80, 16);
            this.radioButtonShadowStyleGradual.TabIndex = 2;
            this.radioButtonShadowStyleGradual.TabStop = true;
            this.radioButtonShadowStyleGradual.Tag = "";
            this.radioButtonShadowStyleGradual.Text = "&Gradual";
            this.radioButtonShadowStyleGradual.CheckedChanged += new System.EventHandler(this.radioButtonShadowStyle_Changed);
            // 
            // radioButtonShadowStyleUniform
            // 
            this.radioButtonShadowStyleUniform.Location = new System.Drawing.Point(16, 38);
            this.radioButtonShadowStyleUniform.Name = "radioButtonShadowStyleUniform";
            this.radioButtonShadowStyleUniform.Size = new System.Drawing.Size(80, 16);
            this.radioButtonShadowStyleUniform.TabIndex = 1;
            this.radioButtonShadowStyleUniform.Tag = "";
            this.radioButtonShadowStyleUniform.Text = "&Uniform";
            this.radioButtonShadowStyleUniform.CheckedChanged += new System.EventHandler(this.radioButtonShadowStyle_Changed);
            // 
            // radioButtonShadowStyleNone
            // 
            this.radioButtonShadowStyleNone.Location = new System.Drawing.Point(16, 18);
            this.radioButtonShadowStyleNone.Name = "radioButtonShadowStyleNone";
            this.radioButtonShadowStyleNone.Size = new System.Drawing.Size(80, 16);
            this.radioButtonShadowStyleNone.TabIndex = 0;
            this.radioButtonShadowStyleNone.Tag = "";
            this.radioButtonShadowStyleNone.Text = "&None";
            this.radioButtonShadowStyleNone.CheckedChanged += new System.EventHandler(this.radioButtonShadowStyle_Changed);
            // 
            // m_buttonPrint
            // 
            this.m_buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonPrint.Location = new System.Drawing.Point(317, 20);
            this.m_buttonPrint.Name = "m_buttonPrint";
            this.m_buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.m_buttonPrint.TabIndex = 29;
            this.m_buttonPrint.Text = "Save Image";
            this.m_buttonPrint.Click += new System.EventHandler(this.m_buttonPrint_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_buttonPrint);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(234, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 66);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pieChartControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(234, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 445);
            this.panel3.TabIndex = 2;
            // 
            // pieChartControl
            // 
            this.pieChartControl.BackColor = System.Drawing.SystemColors.Window;
            this.pieChartControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pieChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartControl.Location = new System.Drawing.Point(0, 0);
            this.pieChartControl.Name = "pieChartControl";
            this.pieChartControl.Size = new System.Drawing.Size(553, 445);
            this.pieChartControl.TabIndex = 0;
            this.pieChartControl.ToolTips = null;
            // 
            // frmPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPieChart";
            this.Text = "frmPieChart";
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_numericUpDownAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdgeLineWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPieHeight)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottomMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRightMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeftMargin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown m_numericUpDownAlpha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxFitChart;
        private System.Windows.Forms.NumericUpDown numericUpDownEdgeLineWidth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDownBottomMargin;
        private System.Windows.Forms.NumericUpDown numericUpDownTopMargin;
        private System.Windows.Forms.NumericUpDown numericUpDownRightMargin;
        private System.Windows.Forms.NumericUpDown numericUpDownLeftMargin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEdgeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPieHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonShadowStyleGradual;
        private System.Windows.Forms.RadioButton radioButtonShadowStyleUniform;
        private System.Windows.Forms.RadioButton radioButtonShadowStyleNone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.Button m_buttonPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Drawing.PieChart.PieChartControl pieChartControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.CheckBox checkBoxGroup;
        private System.Windows.Forms.CheckBox checkBoxRemoveZeroValue;
    }
}