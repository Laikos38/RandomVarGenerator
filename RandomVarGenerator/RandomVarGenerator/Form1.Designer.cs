namespace RandomVarGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartFreq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbDistribution = new System.Windows.Forms.ComboBox();
            this.lblDistribution = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.lblLambda = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIntervalsQuantity = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbIntervalsQuantity = new System.Windows.Forms.ComboBox();
            this.lblGeneratedList = new System.Windows.Forms.Label();
            this.txtGeneratedList = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTabuledChi = new System.Windows.Forms.Label();
            this.lblObtainedChiSum = new System.Windows.Forms.Label();
            this.txtObtainedSChiSum = new System.Windows.Forms.TextBox();
            this.txtTabuledChi = new System.Windows.Forms.TextBox();
            this.lblRta = new System.Windows.Forms.Label();
            this.txtRtaRandom = new System.Windows.Forms.TextBox();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.colIntervals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservableFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWaitedFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperation1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperation2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).BeginInit();
            this.gbParameters.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1020, 562);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gbParameters);
            this.tabPage1.Controls.Add(this.lblGeneratedList);
            this.tabPage1.Controls.Add(this.txtGeneratedList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chartFreq);
            this.groupBox1.Location = new System.Drawing.Point(167, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 347);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gráfico";
            // 
            // chartFreq
            // 
            this.chartFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartFreq.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFreq.Legends.Add(legend4);
            this.chartFreq.Location = new System.Drawing.Point(7, 42);
            this.chartFreq.Name = "chartFreq";
            this.chartFreq.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Freq observada";
            this.chartFreq.Series.Add(series4);
            this.chartFreq.Size = new System.Drawing.Size(826, 299);
            this.chartFreq.TabIndex = 0;
            this.chartFreq.Text = "chart1";
            // 
            // gbParameters
            // 
            this.gbParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParameters.Controls.Add(this.btnClean);
            this.gbParameters.Controls.Add(this.btnGenerate);
            this.gbParameters.Controls.Add(this.tableLayoutPanel3);
            this.gbParameters.Controls.Add(this.tableLayoutPanel2);
            this.gbParameters.Controls.Add(this.tableLayoutPanel1);
            this.gbParameters.Location = new System.Drawing.Point(166, 23);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(840, 154);
            this.gbParameters.TabIndex = 2;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Parámetros";
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.Location = new System.Drawing.Point(748, 114);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(666, 114);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.42857F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.57143F));
            this.tableLayoutPanel3.Controls.Add(this.cmbDistribution, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDistribution, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtLambda, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblLambda, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(547, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.4382F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5618F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 89);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // cmbDistribution
            // 
            this.cmbDistribution.FormattingEnabled = true;
            this.cmbDistribution.Items.AddRange(new object[] {
            "Uniforme",
            "Poisson",
            "Exponencial",
            "Normal - Box Muller",
            "Normal - Convolucion"});
            this.cmbDistribution.Location = new System.Drawing.Point(121, 46);
            this.cmbDistribution.Name = "cmbDistribution";
            this.cmbDistribution.Size = new System.Drawing.Size(155, 21);
            this.cmbDistribution.TabIndex = 5;
            this.cmbDistribution.SelectedIndexChanged += new System.EventHandler(this.cmbDistribution_SelectedIndexChanged);
            // 
            // lblDistribution
            // 
            this.lblDistribution.AutoSize = true;
            this.lblDistribution.Location = new System.Drawing.Point(7, 50);
            this.lblDistribution.Margin = new System.Windows.Forms.Padding(7);
            this.lblDistribution.Name = "lblDistribution";
            this.lblDistribution.Size = new System.Drawing.Size(65, 13);
            this.lblDistribution.TabIndex = 5;
            this.lblDistribution.Text = "Distribución:";
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(121, 3);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(155, 20);
            this.txtLambda.TabIndex = 1;
            this.txtLambda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowNegativeIntegerNumbers);
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Location = new System.Drawing.Point(7, 7);
            this.lblLambda.Margin = new System.Windows.Forms.Padding(7);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(48, 13);
            this.lblLambda.TabIndex = 4;
            this.lblLambda.Text = "Lambda:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.14851F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.85149F));
            this.tableLayoutPanel2.Controls.Add(this.lblInput2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtInput1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtInput2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblInput1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(324, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.4382F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5618F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 89);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Location = new System.Drawing.Point(7, 50);
            this.lblInput2.Margin = new System.Windows.Forms.Padding(7);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(17, 13);
            this.lblInput2.TabIndex = 5;
            this.lblInput2.Text = "B:";
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(80, 3);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(121, 20);
            this.txtInput1.TabIndex = 1;
            this.txtInput1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowNegativeIntegerNumbers);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(80, 46);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(121, 20);
            this.txtInput2.TabIndex = 3;
            this.txtInput2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowNegativeIntegerNumbers);
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Location = new System.Drawing.Point(7, 7);
            this.lblInput1.Margin = new System.Windows.Forms.Padding(7);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(17, 13);
            this.lblInput1.TabIndex = 4;
            this.lblInput1.Text = "A:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.39857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.60143F));
            this.tableLayoutPanel1.Controls.Add(this.lblIntervalsQuantity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbIntervalsQuantity, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.4382F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5618F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 89);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblIntervalsQuantity
            // 
            this.lblIntervalsQuantity.AutoSize = true;
            this.lblIntervalsQuantity.Location = new System.Drawing.Point(7, 50);
            this.lblIntervalsQuantity.Margin = new System.Windows.Forms.Padding(7);
            this.lblIntervalsQuantity.Name = "lblIntervalsQuantity";
            this.lblIntervalsQuantity.Size = new System.Drawing.Size(115, 13);
            this.lblIntervalsQuantity.TabIndex = 4;
            this.lblIntervalsQuantity.Text = "Cantidad de intervalos:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(7, 7);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(7);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(113, 13);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Cantidad n° a generar:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(155, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(136, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowPositiveIntegerNumbers);
            // 
            // cmbIntervalsQuantity
            // 
            this.cmbIntervalsQuantity.FormattingEnabled = true;
            this.cmbIntervalsQuantity.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cmbIntervalsQuantity.Location = new System.Drawing.Point(155, 46);
            this.cmbIntervalsQuantity.Name = "cmbIntervalsQuantity";
            this.cmbIntervalsQuantity.Size = new System.Drawing.Size(136, 21);
            this.cmbIntervalsQuantity.TabIndex = 3;
            // 
            // lblGeneratedList
            // 
            this.lblGeneratedList.AutoSize = true;
            this.lblGeneratedList.Location = new System.Drawing.Point(7, 7);
            this.lblGeneratedList.Name = "lblGeneratedList";
            this.lblGeneratedList.Size = new System.Drawing.Size(80, 13);
            this.lblGeneratedList.TabIndex = 1;
            this.lblGeneratedList.Text = "Lista generada:";
            // 
            // txtGeneratedList
            // 
            this.txtGeneratedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGeneratedList.Location = new System.Drawing.Point(6, 23);
            this.txtGeneratedList.Multiline = true;
            this.txtGeneratedList.Name = "txtGeneratedList";
            this.txtGeneratedList.ReadOnly = true;
            this.txtGeneratedList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGeneratedList.Size = new System.Drawing.Size(154, 507);
            this.txtGeneratedList.TabIndex = 0;
            this.txtGeneratedList.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTabuledChi);
            this.tabPage2.Controls.Add(this.lblObtainedChiSum);
            this.tabPage2.Controls.Add(this.txtObtainedSChiSum);
            this.tabPage2.Controls.Add(this.txtTabuledChi);
            this.tabPage2.Controls.Add(this.lblRta);
            this.tabPage2.Controls.Add(this.txtRtaRandom);
            this.tabPage2.Controls.Add(this.dgvChi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Cuadrado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTabuledChi
            // 
            this.lblTabuledChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTabuledChi.AutoSize = true;
            this.lblTabuledChi.Location = new System.Drawing.Point(22, 462);
            this.lblTabuledChi.Name = "lblTabuledChi";
            this.lblTabuledChi.Size = new System.Drawing.Size(73, 13);
            this.lblTabuledChi.TabIndex = 16;
            this.lblTabuledChi.Text = "Chi Tabulado:";
            // 
            // lblObtainedChiSum
            // 
            this.lblObtainedChiSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblObtainedChiSum.AutoSize = true;
            this.lblObtainedChiSum.Location = new System.Drawing.Point(22, 427);
            this.lblObtainedChiSum.Name = "lblObtainedChiSum";
            this.lblObtainedChiSum.Size = new System.Drawing.Size(139, 13);
            this.lblObtainedChiSum.TabIndex = 15;
            this.lblObtainedChiSum.Text = "Sumatoria de Chi Cuadrado:";
            // 
            // txtObtainedSChiSum
            // 
            this.txtObtainedSChiSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObtainedSChiSum.Location = new System.Drawing.Point(167, 424);
            this.txtObtainedSChiSum.Name = "txtObtainedSChiSum";
            this.txtObtainedSChiSum.ReadOnly = true;
            this.txtObtainedSChiSum.Size = new System.Drawing.Size(108, 20);
            this.txtObtainedSChiSum.TabIndex = 14;
            // 
            // txtTabuledChi
            // 
            this.txtTabuledChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTabuledChi.Location = new System.Drawing.Point(167, 459);
            this.txtTabuledChi.Name = "txtTabuledChi";
            this.txtTabuledChi.ReadOnly = true;
            this.txtTabuledChi.Size = new System.Drawing.Size(108, 20);
            this.txtTabuledChi.TabIndex = 13;
            // 
            // lblRta
            // 
            this.lblRta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRta.AutoSize = true;
            this.lblRta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRta.Location = new System.Drawing.Point(22, 493);
            this.lblRta.Name = "lblRta";
            this.lblRta.Size = new System.Drawing.Size(82, 13);
            this.lblRta.TabIndex = 12;
            this.lblRta.Text = "RESULTADO";
            // 
            // txtRtaRandom
            // 
            this.txtRtaRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRtaRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtaRandom.Location = new System.Drawing.Point(167, 493);
            this.txtRtaRandom.Name = "txtRtaRandom";
            this.txtRtaRandom.ReadOnly = true;
            this.txtRtaRandom.Size = new System.Drawing.Size(162, 20);
            this.txtRtaRandom.TabIndex = 11;
            // 
            // dgvChi
            // 
            this.dgvChi.AllowUserToAddRows = false;
            this.dgvChi.AllowUserToDeleteRows = false;
            this.dgvChi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIntervals,
            this.colObservableFreq,
            this.colWaitedFreq,
            this.colOperation1,
            this.colOperation2,
            this.colSum});
            this.dgvChi.Location = new System.Drawing.Point(6, 6);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.Size = new System.Drawing.Size(1000, 398);
            this.dgvChi.TabIndex = 0;
            // 
            // colIntervals
            // 
            this.colIntervals.HeaderText = "Intervalos";
            this.colIntervals.Name = "colIntervals";
            // 
            // colObservableFreq
            // 
            this.colObservableFreq.HeaderText = "Frec. Observada";
            this.colObservableFreq.Name = "colObservableFreq";
            // 
            // colWaitedFreq
            // 
            this.colWaitedFreq.HeaderText = "Frec. Esperada";
            this.colWaitedFreq.Name = "colWaitedFreq";
            // 
            // colOperation1
            // 
            this.colOperation1.HeaderText = "(fo-fe)^2";
            this.colOperation1.Name = "colOperation1";
            // 
            // colOperation2
            // 
            this.colOperation2.HeaderText = "(col4)/fe";
            this.colOperation2.Name = "colOperation2";
            // 
            // colSum
            // 
            this.colSum.HeaderText = "Sumatoria";
            this.colSum.Name = "colSum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 586);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(1060, 625);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).EndInit();
            this.gbParameters.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.Label lblGeneratedList;
        private System.Windows.Forms.TextBox txtGeneratedList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbIntervalsQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblDistribution;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblIntervalsQuantity;
        private System.Windows.Forms.ComboBox cmbDistribution;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTabuledChi;
        private System.Windows.Forms.Label lblObtainedChiSum;
        private System.Windows.Forms.TextBox txtObtainedSChiSum;
        private System.Windows.Forms.TextBox txtTabuledChi;
        private System.Windows.Forms.Label lblRta;
        private System.Windows.Forms.TextBox txtRtaRandom;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntervals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservableFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaitedFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperation1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperation2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chartFreq;
    }
}

