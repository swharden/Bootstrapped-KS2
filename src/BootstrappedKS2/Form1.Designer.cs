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
            this.btnPasteA = new System.Windows.Forms.Button();
            this.btnPasteB = new System.Windows.Forms.Button();
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
            this.groupBootstrap = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnAutoSampleSize = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudRunCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSampleSize = new System.Windows.Forms.NumericUpDown();
            this.groupSampleEstimator = new System.Windows.Forms.GroupBox();
            this.lblSampleEstimatorMessage = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSampleSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudPower = new System.Windows.Forms.NumericUpDown();
            this.nudSignificance = new System.Windows.Forms.NumericUpDown();
            this.nudMeanDiff = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbBootstrapResults = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBinSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBootstrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleSize)).BeginInit();
            this.groupSampleEstimator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSignificance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeanDiff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPasteA
            // 
            this.btnPasteA.Location = new System.Drawing.Point(91, 12);
            this.btnPasteA.Name = "btnPasteA";
            this.btnPasteA.Size = new System.Drawing.Size(62, 23);
            this.btnPasteA.TabIndex = 0;
            this.btnPasteA.Text = "paste A";
            this.btnPasteA.UseVisualStyleBackColor = true;
            this.btnPasteA.Click += new System.EventHandler(this.BtnPasteA_Click);
            // 
            // btnPasteB
            // 
            this.btnPasteB.Location = new System.Drawing.Point(163, 12);
            this.btnPasteB.Name = "btnPasteB";
            this.btnPasteB.Size = new System.Drawing.Size(63, 23);
            this.btnPasteB.TabIndex = 1;
            this.btnPasteB.Text = "paste B";
            this.btnPasteB.UseVisualStyleBackColor = true;
            this.btnPasteB.Click += new System.EventHandler(this.BtnPasteB_Click);
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
            this.scottPlotUC1.Size = new System.Drawing.Size(623, 654);
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
            0});
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
            // groupBootstrap
            // 
            this.groupBootstrap.Controls.Add(this.rtbBootstrapResults);
            this.groupBootstrap.Controls.Add(this.btnRun);
            this.groupBootstrap.Controls.Add(this.progressBar1);
            this.groupBootstrap.Controls.Add(this.btnAutoSampleSize);
            this.groupBootstrap.Controls.Add(this.label6);
            this.groupBootstrap.Controls.Add(this.nudRunCount);
            this.groupBootstrap.Controls.Add(this.label5);
            this.groupBootstrap.Controls.Add(this.nudSampleSize);
            this.groupBootstrap.Location = new System.Drawing.Point(12, 304);
            this.groupBootstrap.Name = "groupBootstrap";
            this.groupBootstrap.Size = new System.Drawing.Size(218, 169);
            this.groupBootstrap.TabIndex = 16;
            this.groupBootstrap.TabStop = false;
            this.groupBootstrap.Text = "Bootstrap";
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
            this.progressBar1.MarqueeAnimationSpeed = 0;
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
            // groupSampleEstimator
            // 
            this.groupSampleEstimator.Controls.Add(this.lblSampleEstimatorMessage);
            this.groupSampleEstimator.Controls.Add(this.label12);
            this.groupSampleEstimator.Controls.Add(this.tbSampleSize);
            this.groupSampleEstimator.Controls.Add(this.label11);
            this.groupSampleEstimator.Controls.Add(this.label9);
            this.groupSampleEstimator.Controls.Add(this.nudPower);
            this.groupSampleEstimator.Controls.Add(this.nudSignificance);
            this.groupSampleEstimator.Controls.Add(this.nudMeanDiff);
            this.groupSampleEstimator.Controls.Add(this.label8);
            this.groupSampleEstimator.Location = new System.Drawing.Point(12, 495);
            this.groupSampleEstimator.Name = "groupSampleEstimator";
            this.groupSampleEstimator.Size = new System.Drawing.Size(218, 140);
            this.groupSampleEstimator.TabIndex = 17;
            this.groupSampleEstimator.TabStop = false;
            this.groupSampleEstimator.Text = "Sample Size Estimator";
            // 
            // lblSampleEstimatorMessage
            // 
            this.lblSampleEstimatorMessage.AutoSize = true;
            this.lblSampleEstimatorMessage.Enabled = false;
            this.lblSampleEstimatorMessage.Location = new System.Drawing.Point(61, 121);
            this.lblSampleEstimatorMessage.Name = "lblSampleEstimatorMessage";
            this.lblSampleEstimatorMessage.Size = new System.Drawing.Size(143, 13);
            this.lblSampleEstimatorMessage.TabIndex = 25;
            this.lblSampleEstimatorMessage.Text = "123% of of available samples";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "sample count:";
            // 
            // tbSampleSize
            // 
            this.tbSampleSize.Location = new System.Drawing.Point(140, 97);
            this.tbSampleSize.Name = "tbSampleSize";
            this.tbSampleSize.ReadOnly = true;
            this.tbSampleSize.Size = new System.Drawing.Size(72, 20);
            this.tbSampleSize.TabIndex = 18;
            this.tbSampleSize.Text = "12345";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "power:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "significance:";
            // 
            // nudPower
            // 
            this.nudPower.DecimalPlaces = 2;
            this.nudPower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPower.Location = new System.Drawing.Point(140, 71);
            this.nudPower.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPower.Name = "nudPower";
            this.nudPower.Size = new System.Drawing.Size(72, 20);
            this.nudPower.TabIndex = 21;
            this.nudPower.Value = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.nudPower.ValueChanged += new System.EventHandler(this.NudPower_ValueChanged);
            // 
            // nudSignificance
            // 
            this.nudSignificance.DecimalPlaces = 2;
            this.nudSignificance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSignificance.Location = new System.Drawing.Point(140, 45);
            this.nudSignificance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSignificance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSignificance.Name = "nudSignificance";
            this.nudSignificance.Size = new System.Drawing.Size(72, 20);
            this.nudSignificance.TabIndex = 20;
            this.nudSignificance.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudSignificance.ValueChanged += new System.EventHandler(this.NudSignificance_ValueChanged);
            // 
            // nudMeanDiff
            // 
            this.nudMeanDiff.DecimalPlaces = 1;
            this.nudMeanDiff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMeanDiff.Location = new System.Drawing.Point(140, 19);
            this.nudMeanDiff.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMeanDiff.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMeanDiff.Name = "nudMeanDiff";
            this.nudMeanDiff.Size = new System.Drawing.Size(72, 20);
            this.nudMeanDiff.TabIndex = 19;
            this.nudMeanDiff.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMeanDiff.ValueChanged += new System.EventHandler(this.NudMeanDiff_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "target mean difference:";
            // 
            // rtbBootstrapResults
            // 
            this.rtbBootstrapResults.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBootstrapResults.Location = new System.Drawing.Point(6, 99);
            this.rtbBootstrapResults.Name = "rtbBootstrapResults";
            this.rtbBootstrapResults.Size = new System.Drawing.Size(206, 64);
            this.rtbBootstrapResults.TabIndex = 18;
            this.rtbBootstrapResults.Text = "bootstrap not yet run...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 678);
            this.Controls.Add(this.groupSampleEstimator);
            this.Controls.Add(this.groupBootstrap);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scottPlotUC1);
            this.Controls.Add(this.btnPasteB);
            this.Controls.Add(this.btnPasteA);
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
            this.groupBootstrap.ResumeLayout(false);
            this.groupBootstrap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleSize)).EndInit();
            this.groupSampleEstimator.ResumeLayout(false);
            this.groupSampleEstimator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSignificance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeanDiff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPasteA;
        private System.Windows.Forms.Button btnPasteB;
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
        private System.Windows.Forms.GroupBox groupBootstrap;
        private System.Windows.Forms.Button btnAutoSampleSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudRunCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSampleSize;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupSampleEstimator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudPower;
        private System.Windows.Forms.NumericUpDown nudSignificance;
        private System.Windows.Forms.NumericUpDown nudMeanDiff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSampleSize;
        private System.Windows.Forms.Label lblSampleEstimatorMessage;
        private System.Windows.Forms.RichTextBox rtbBootstrapResults;
    }
}

