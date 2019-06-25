namespace BootstrappedKS2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblStdErrA = new System.Windows.Forms.Label();
            this.lblStdErrB = new System.Windows.Forms.Label();
            this.lblStdevB = new System.Windows.Forms.Label();
            this.lblStdevA = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMeanB = new System.Windows.Forms.Label();
            this.lblMeanA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCountB = new System.Windows.Forms.Label();
            this.lblCountA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scottPlotUC1 = new ScottPlot.ScottPlotUC();
            this.lblValuesP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKLine = new System.Windows.Forms.RadioButton();
            this.rbCPH = new System.Windows.Forms.RadioButton();
            this.rbHistogram = new System.Windows.Forms.RadioButton();
            this.nudBinSize = new System.Windows.Forms.NumericUpDown();
            this.lblKsD = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblKsP = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAutoSampleSize = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudRunCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSampleSize = new System.Windows.Forms.NumericUpDown();
            this.lblBootstrapD = new System.Windows.Forms.Label();
            this.lblBootstrapP = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBinSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleSize)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "paste A";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "paste B";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblStdErrA, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblStdErrB, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblStdevB, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblStdevA, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMeanB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMeanA, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCountB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCountA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 117);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(4, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 23);
            this.label15.TabIndex = 15;
            this.label15.Text = "stdErr";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStdErrA
            // 
            this.lblStdErrA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStdErrA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdErrA.Location = new System.Drawing.Point(76, 93);
            this.lblStdErrA.Name = "lblStdErrA";
            this.lblStdErrA.Size = new System.Drawing.Size(65, 23);
            this.lblStdErrA.TabIndex = 14;
            this.lblStdErrA.Text = "label15";
            this.lblStdErrA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStdErrB
            // 
            this.lblStdErrB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStdErrB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdErrB.Location = new System.Drawing.Point(148, 93);
            this.lblStdErrB.Name = "lblStdErrB";
            this.lblStdErrB.Size = new System.Drawing.Size(66, 23);
            this.lblStdErrB.TabIndex = 13;
            this.lblStdErrB.Text = "label14";
            this.lblStdErrB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStdevB
            // 
            this.lblStdevB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStdevB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdevB.Location = new System.Drawing.Point(148, 70);
            this.lblStdevB.Name = "lblStdevB";
            this.lblStdevB.Size = new System.Drawing.Size(66, 22);
            this.lblStdevB.TabIndex = 11;
            this.lblStdevB.Text = "label12";
            this.lblStdevB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStdevA
            // 
            this.lblStdevA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStdevA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdevA.Location = new System.Drawing.Point(76, 70);
            this.lblStdevA.Name = "lblStdevA";
            this.lblStdevA.Size = new System.Drawing.Size(65, 22);
            this.lblStdevA.TabIndex = 10;
            this.lblStdevA.Text = "label11";
            this.lblStdevA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(4, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "stdev";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMeanB
            // 
            this.lblMeanB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeanB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeanB.Location = new System.Drawing.Point(148, 47);
            this.lblMeanB.Name = "lblMeanB";
            this.lblMeanB.Size = new System.Drawing.Size(66, 22);
            this.lblMeanB.TabIndex = 8;
            this.lblMeanB.Text = "label9";
            this.lblMeanB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMeanA
            // 
            this.lblMeanA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeanA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeanA.Location = new System.Drawing.Point(76, 47);
            this.lblMeanA.Name = "lblMeanA";
            this.lblMeanA.Size = new System.Drawing.Size(65, 22);
            this.lblMeanA.TabIndex = 7;
            this.lblMeanA.Text = "label8";
            this.lblMeanA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "mean";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountB
            // 
            this.lblCountB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountB.Location = new System.Drawing.Point(148, 24);
            this.lblCountB.Name = "lblCountB";
            this.lblCountB.Size = new System.Drawing.Size(66, 22);
            this.lblCountB.TabIndex = 5;
            this.lblCountB.Text = "label6";
            this.lblCountB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountA
            // 
            this.lblCountA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountA.Location = new System.Drawing.Point(76, 24);
            this.lblCountA.Name = "lblCountA";
            this.lblCountA.Size = new System.Drawing.Size(65, 22);
            this.lblCountA.TabIndex = 4;
            this.lblCountA.Text = "label5";
            this.lblCountA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "count";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(148, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(76, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scottPlotUC1
            // 
            this.scottPlotUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scottPlotUC1.Location = new System.Drawing.Point(236, 12);
            this.scottPlotUC1.Name = "scottPlotUC1";
            this.scottPlotUC1.Size = new System.Drawing.Size(623, 485);
            this.scottPlotUC1.TabIndex = 4;
            // 
            // lblValuesP
            // 
            this.lblValuesP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValuesP.Location = new System.Drawing.Point(3, 16);
            this.lblValuesP.Name = "lblValuesP";
            this.lblValuesP.Size = new System.Drawing.Size(108, 21);
            this.lblValuesP.TabIndex = 5;
            this.lblValuesP.Text = "P = 1.234";
            this.lblValuesP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKLine);
            this.groupBox1.Controls.Add(this.rbCPH);
            this.groupBox1.Controls.Add(this.rbHistogram);
            this.groupBox1.Location = new System.Drawing.Point(132, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // rbKLine
            // 
            this.rbKLine.AutoSize = true;
            this.rbKLine.Location = new System.Drawing.Point(6, 65);
            this.rbKLine.Name = "rbKLine";
            this.rbKLine.Size = new System.Drawing.Size(55, 17);
            this.rbKLine.TabIndex = 10;
            this.rbKLine.Text = "K Line";
            this.rbKLine.UseVisualStyleBackColor = true;
            // 
            // rbCPH
            // 
            this.rbCPH.AutoSize = true;
            this.rbCPH.Location = new System.Drawing.Point(6, 42);
            this.rbCPH.Name = "rbCPH";
            this.rbCPH.Size = new System.Drawing.Size(47, 17);
            this.rbCPH.TabIndex = 9;
            this.rbCPH.Text = "CPH";
            this.rbCPH.UseVisualStyleBackColor = true;
            this.rbCPH.CheckedChanged += new System.EventHandler(this.RbCPH_CheckedChanged);
            // 
            // rbHistogram
            // 
            this.rbHistogram.AutoSize = true;
            this.rbHistogram.Checked = true;
            this.rbHistogram.Location = new System.Drawing.Point(7, 19);
            this.rbHistogram.Name = "rbHistogram";
            this.rbHistogram.Size = new System.Drawing.Size(70, 17);
            this.rbHistogram.TabIndex = 8;
            this.rbHistogram.TabStop = true;
            this.rbHistogram.Text = "histogram";
            this.rbHistogram.UseVisualStyleBackColor = true;
            this.rbHistogram.CheckedChanged += new System.EventHandler(this.RbHistogram_CheckedChanged);
            // 
            // nudBinSize
            // 
            this.nudBinSize.DecimalPlaces = 1;
            this.nudBinSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBinSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBinSize.Location = new System.Drawing.Point(3, 16);
            this.nudBinSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBinSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBinSize.Name = "nudBinSize";
            this.nudBinSize.Size = new System.Drawing.Size(108, 20);
            this.nudBinSize.TabIndex = 8;
            this.nudBinSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBinSize.ValueChanged += new System.EventHandler(this.NudBinSize_ValueChanged);
            // 
            // lblKsD
            // 
            this.lblKsD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKsD.Location = new System.Drawing.Point(3, 0);
            this.lblKsD.Name = "lblKsD";
            this.lblKsD.Size = new System.Drawing.Size(100, 23);
            this.lblKsD.TabIndex = 10;
            this.lblKsD.Text = "D = 1.323";
            this.lblKsD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblValuesP);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 40);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "T Test";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudBinSize);
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 40);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bin Size";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Location = new System.Drawing.Point(12, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 42);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "KS Test (all data)";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblKsP, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblKsD, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(212, 23);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // lblKsP
            // 
            this.lblKsP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKsP.Location = new System.Drawing.Point(109, 0);
            this.lblKsP.Name = "lblKsP";
            this.lblKsP.Size = new System.Drawing.Size(100, 23);
            this.lblKsP.TabIndex = 12;
            this.lblKsP.Text = "P = .123";
            this.lblKsP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblBootstrapP);
            this.groupBox5.Controls.Add(this.lblBootstrapD);
            this.groupBox5.Controls.Add(this.btnRun);
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Controls.Add(this.btnAutoSampleSize);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.nudRunCount);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.nudSampleSize);
            this.groupBox5.Location = new System.Drawing.Point(12, 304);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 128);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bootstrap";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(164, 42);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(48, 23);
            this.btnRun.TabIndex = 22;
            this.btnRun.Text = "run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(206, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // btnAutoSampleSize
            // 
            this.btnAutoSampleSize.Enabled = false;
            this.btnAutoSampleSize.Location = new System.Drawing.Point(164, 16);
            this.btnAutoSampleSize.Name = "btnAutoSampleSize";
            this.btnAutoSampleSize.Size = new System.Drawing.Size(48, 23);
            this.btnAutoSampleSize.TabIndex = 21;
            this.btnAutoSampleSize.Text = "auto";
            this.btnAutoSampleSize.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "runs:";
            // 
            // nudRunCount
            // 
            this.nudRunCount.Location = new System.Drawing.Point(76, 44);
            this.nudRunCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudRunCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRunCount.Name = "nudRunCount";
            this.nudRunCount.Size = new System.Drawing.Size(82, 20);
            this.nudRunCount.TabIndex = 19;
            this.nudRunCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRunCount.ValueChanged += new System.EventHandler(this.NudRunCount_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "sample size:";
            // 
            // nudSampleSize
            // 
            this.nudSampleSize.Location = new System.Drawing.Point(76, 18);
            this.nudSampleSize.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudSampleSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSampleSize.Name = "nudSampleSize";
            this.nudSampleSize.Size = new System.Drawing.Size(82, 20);
            this.nudSampleSize.TabIndex = 17;
            this.nudSampleSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblBootstrapD
            // 
            this.lblBootstrapD.AutoSize = true;
            this.lblBootstrapD.Location = new System.Drawing.Point(6, 96);
            this.lblBootstrapD.Name = "lblBootstrapD";
            this.lblBootstrapD.Size = new System.Drawing.Size(113, 13);
            this.lblBootstrapD.TabIndex = 23;
            this.lblBootstrapD.Text = "bootstrap not yet run...";
            // 
            // lblBootstrapP
            // 
            this.lblBootstrapP.AutoSize = true;
            this.lblBootstrapP.Location = new System.Drawing.Point(6, 109);
            this.lblBootstrapP.Name = "lblBootstrapP";
            this.lblBootstrapP.Size = new System.Drawing.Size(113, 13);
            this.lblBootstrapP.TabIndex = 24;
            this.lblBootstrapP.Text = "bootstrap not yet run...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 509);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scottPlotUC1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Bootstrapped KS2 Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBinSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblStdErrA;
        private System.Windows.Forms.Label lblStdErrB;
        private System.Windows.Forms.Label lblStdevB;
        private System.Windows.Forms.Label lblStdevA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMeanB;
        private System.Windows.Forms.Label lblMeanA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCountB;
        private System.Windows.Forms.Label lblCountA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ScottPlot.ScottPlotUC scottPlotUC1;
        private System.Windows.Forms.Label lblValuesP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCPH;
        private System.Windows.Forms.RadioButton rbHistogram;
        private System.Windows.Forms.NumericUpDown nudBinSize;
        private System.Windows.Forms.RadioButton rbKLine;
        private System.Windows.Forms.Label lblKsD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblKsP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAutoSampleSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudRunCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSampleSize;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblBootstrapP;
        private System.Windows.Forms.Label lblBootstrapD;
    }
}

