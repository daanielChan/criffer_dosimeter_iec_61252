namespace dosimetro_iec_61252
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            header1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel21 = new TableLayoutPanel();
            tableLayoutPanel24 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel27 = new TableLayoutPanel();
            btnSaveToExcel = new Button();
            btnExcelToProgram = new Button();
            tableLayoutPanel18 = new TableLayoutPanel();
            tableLayoutPanel19 = new TableLayoutPanel();
            tableLayoutPanel23 = new TableLayoutPanel();
            btnTestGenerator = new Button();
            btnUpdate = new Button();
            tableLayoutPanel20 = new TableLayoutPanel();
            label11 = new Label();
            comboBox1 = new ComboBox();
            label12 = new Label();
            tableLayoutPanel16 = new TableLayoutPanel();
            label7 = new Label();
            tableLayoutPanel17 = new TableLayoutPanel();
            label8 = new Label();
            pressUpDown = new NumericUpDown();
            umidUpDown = new NumericUpDown();
            label9 = new Label();
            tempUpDown = new NumericUpDown();
            label10 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            DownFreqFix = new Label();
            lblDownFreq = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            UpFreqFix = new Label();
            lblUpFreq = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            DownLimFix = new Label();
            lblDownLim = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            UpLimFix = new Label();
            lblUpLim = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            RefLvlFix = new Label();
            lblRefLvl = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            ParMedFixed = new Label();
            lblParMed = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel26 = new TableLayoutPanel();
            button5 = new Button();
            button4 = new Button();
            tableLayoutPanel11 = new TableLayoutPanel();
            CerCalibFix = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            lblDataLbl = new Label();
            NúmeroLblFix = new Label();
            NumUpDown = new NumericUpDown();
            DataLblFix = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            tableLayoutPanel15 = new TableLayoutPanel();
            lblFilePathAndName = new Label();
            btnFileSelect = new Button();
            FileSelectFix = new Label();
            label13 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel14 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel22 = new TableLayoutPanel();
            tableLayoutPanel25 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel21.SuspendLayout();
            tableLayoutPanel24.SuspendLayout();
            tableLayoutPanel27.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            tableLayoutPanel19.SuspendLayout();
            tableLayoutPanel23.SuspendLayout();
            tableLayoutPanel20.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pressUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umidUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tempUpDown).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel26.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumUpDown).BeginInit();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            SuspendLayout();
            // 
            // header1
            // 
            header1.Anchor = AnchorStyles.None;
            header1.AutoEllipsis = true;
            header1.AutoSize = true;
            header1.Font = new Font("Arial Black", 15F);
            header1.Location = new Point(25, 51);
            header1.Name = "header1";
            header1.Size = new Size(201, 51);
            header1.TabIndex = 0;
            header1.Text = "Configurações do Equipamento";
            header1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel21, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel18, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel16, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 2, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 2, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel11, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel13, 0, 1);
            tableLayoutPanel1.Controls.Add(label13, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(784, 561);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel21
            // 
            tableLayoutPanel21.BackColor = Color.FromArgb(192, 192, 255);
            tableLayoutPanel21.ColumnCount = 1;
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel21.Controls.Add(tableLayoutPanel24, 0, 0);
            tableLayoutPanel21.Controls.Add(tableLayoutPanel27, 0, 1);
            tableLayoutPanel21.Dock = DockStyle.Fill;
            tableLayoutPanel21.Location = new Point(3, 3);
            tableLayoutPanel21.Name = "tableLayoutPanel21";
            tableLayoutPanel21.RowCount = 2;
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel21.Size = new Size(252, 102);
            tableLayoutPanel21.TabIndex = 13;
            // 
            // tableLayoutPanel24
            // 
            tableLayoutPanel24.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel24.ColumnCount = 3;
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel24.Controls.Add(button3, 0, 0);
            tableLayoutPanel24.Controls.Add(button2, 0, 0);
            tableLayoutPanel24.Controls.Add(button1, 0, 0);
            tableLayoutPanel24.Dock = DockStyle.Fill;
            tableLayoutPanel24.Location = new Point(3, 3);
            tableLayoutPanel24.Name = "tableLayoutPanel24";
            tableLayoutPanel24.RowCount = 1;
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel24.Size = new Size(246, 45);
            tableLayoutPanel24.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(167, 4);
            button3.Name = "button3";
            button3.Size = new Size(75, 37);
            button3.TabIndex = 8;
            button3.Text = "Sinais de Curta Duração";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(87, 4);
            button2.Name = "button2";
            button2.Size = new Size(73, 37);
            button2.TabIndex = 7;
            button2.Text = "Resposta em Frequência";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(4, 4);
            button1.Name = "button1";
            button1.Size = new Size(76, 37);
            button1.TabIndex = 6;
            button1.Text = "Linearlidade e Sinais Estáticos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel27
            // 
            tableLayoutPanel27.ColumnCount = 2;
            tableLayoutPanel27.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel27.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel27.Controls.Add(btnSaveToExcel, 0, 0);
            tableLayoutPanel27.Controls.Add(btnExcelToProgram, 1, 0);
            tableLayoutPanel27.Dock = DockStyle.Fill;
            tableLayoutPanel27.Location = new Point(3, 54);
            tableLayoutPanel27.Name = "tableLayoutPanel27";
            tableLayoutPanel27.RowCount = 1;
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel27.Size = new Size(246, 45);
            tableLayoutPanel27.TabIndex = 15;
            // 
            // btnSaveToExcel
            // 
            btnSaveToExcel.BackColor = SystemColors.Highlight;
            btnSaveToExcel.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaveToExcel.Dock = DockStyle.Fill;
            btnSaveToExcel.FlatStyle = FlatStyle.Flat;
            btnSaveToExcel.Location = new Point(3, 3);
            btnSaveToExcel.Name = "btnSaveToExcel";
            btnSaveToExcel.Size = new Size(117, 39);
            btnSaveToExcel.TabIndex = 7;
            btnSaveToExcel.Text = "Salvar no Excel";
            btnSaveToExcel.UseVisualStyleBackColor = false;
            btnSaveToExcel.Click += button7_Click;
            // 
            // btnExcelToProgram
            // 
            btnExcelToProgram.BackColor = SystemColors.Highlight;
            btnExcelToProgram.BackgroundImageLayout = ImageLayout.Zoom;
            btnExcelToProgram.Dock = DockStyle.Fill;
            btnExcelToProgram.FlatStyle = FlatStyle.Flat;
            btnExcelToProgram.Location = new Point(126, 3);
            btnExcelToProgram.Name = "btnExcelToProgram";
            btnExcelToProgram.Size = new Size(117, 39);
            btnExcelToProgram.TabIndex = 6;
            btnExcelToProgram.Text = "Carregar do Excel";
            btnExcelToProgram.UseVisualStyleBackColor = false;
            btnExcelToProgram.Click += button6_Click;
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel18.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel18.ColumnCount = 1;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel18.Controls.Add(tableLayoutPanel19, 1, 1);
            tableLayoutPanel18.Controls.Add(label12, 0, 0);
            tableLayoutPanel18.Dock = DockStyle.Fill;
            tableLayoutPanel18.Location = new Point(3, 219);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 2;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel18.Size = new Size(252, 102);
            tableLayoutPanel18.TabIndex = 12;
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel19.ColumnCount = 2;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.44033F));
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.55967F));
            tableLayoutPanel19.Controls.Add(tableLayoutPanel23, 0, 0);
            tableLayoutPanel19.Controls.Add(tableLayoutPanel20, 0, 0);
            tableLayoutPanel19.Dock = DockStyle.Fill;
            tableLayoutPanel19.Location = new Point(4, 44);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 1;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel19.Size = new Size(244, 54);
            tableLayoutPanel19.TabIndex = 2;
            // 
            // tableLayoutPanel23
            // 
            tableLayoutPanel23.ColumnCount = 2;
            tableLayoutPanel23.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel23.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel23.Controls.Add(btnTestGenerator, 0, 0);
            tableLayoutPanel23.Controls.Add(btnUpdate, 1, 0);
            tableLayoutPanel23.Dock = DockStyle.Fill;
            tableLayoutPanel23.Location = new Point(128, 4);
            tableLayoutPanel23.Name = "tableLayoutPanel23";
            tableLayoutPanel23.RowCount = 1;
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel23.Size = new Size(112, 46);
            tableLayoutPanel23.TabIndex = 16;
            // 
            // btnTestGenerator
            // 
            btnTestGenerator.BackColor = SystemColors.Highlight;
            btnTestGenerator.BackgroundImageLayout = ImageLayout.Zoom;
            btnTestGenerator.Dock = DockStyle.Fill;
            btnTestGenerator.FlatStyle = FlatStyle.Flat;
            btnTestGenerator.Location = new Point(3, 3);
            btnTestGenerator.Name = "btnTestGenerator";
            btnTestGenerator.Size = new Size(50, 40);
            btnTestGenerator.TabIndex = 5;
            btnTestGenerator.Text = "Testar";
            btnTestGenerator.UseVisualStyleBackColor = false;
            btnTestGenerator.Click += btnTestGenerator_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(59, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(50, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Atualizar COM";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.ColumnCount = 1;
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel20.Controls.Add(label11, 0, 0);
            tableLayoutPanel20.Controls.Add(comboBox1, 0, 1);
            tableLayoutPanel20.Dock = DockStyle.Fill;
            tableLayoutPanel20.Location = new Point(4, 4);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.RowCount = 2;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel20.Size = new Size(117, 46);
            tableLayoutPanel20.TabIndex = 6;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F);
            label11.Location = new Point(15, 0);
            label11.Name = "label11";
            label11.Size = new Size(87, 18);
            label11.TabIndex = 1;
            label11.Text = "Porta COM";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.Font = new Font("Arial", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 26);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(23, 1);
            label12.Name = "label12";
            label12.Size = new Size(206, 39);
            label12.TabIndex = 1;
            label12.Text = "Configuração Gerador DS360";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel16.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel16.ColumnCount = 1;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Controls.Add(label7, 0, 0);
            tableLayoutPanel16.Controls.Add(tableLayoutPanel17, 0, 1);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(3, 327);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel16.Size = new Size(252, 102);
            tableLayoutPanel16.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 1);
            label7.Name = "label7";
            label7.Size = new Size(203, 23);
            label7.TabIndex = 0;
            label7.Text = "Condições Ambientais";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel17.ColumnCount = 3;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel17.Controls.Add(label8, 1, 0);
            tableLayoutPanel17.Controls.Add(pressUpDown, 0, 1);
            tableLayoutPanel17.Controls.Add(umidUpDown, 0, 1);
            tableLayoutPanel17.Controls.Add(label9, 0, 0);
            tableLayoutPanel17.Controls.Add(tempUpDown, 0, 1);
            tableLayoutPanel17.Controls.Add(label10, 2, 0);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(4, 29);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 2;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel17.Size = new Size(244, 69);
            tableLayoutPanel17.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(86, 1);
            label8.Name = "label8";
            label8.Size = new Size(73, 33);
            label8.TabIndex = 12;
            label8.Text = "Temperatura (C)";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pressUpDown
            // 
            pressUpDown.Anchor = AnchorStyles.None;
            pressUpDown.Font = new Font("Arial", 12F);
            pressUpDown.Location = new Point(166, 38);
            pressUpDown.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            pressUpDown.Name = "pressUpDown";
            pressUpDown.Size = new Size(74, 26);
            pressUpDown.TabIndex = 4;
            // 
            // umidUpDown
            // 
            umidUpDown.Anchor = AnchorStyles.None;
            umidUpDown.Font = new Font("Arial", 12F);
            umidUpDown.Location = new Point(4, 38);
            umidUpDown.Name = "umidUpDown";
            umidUpDown.Size = new Size(75, 26);
            umidUpDown.TabIndex = 3;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F);
            label9.Location = new Point(5, 1);
            label9.Name = "label9";
            label9.Size = new Size(72, 33);
            label9.TabIndex = 0;
            label9.Text = "Umidade (%)";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tempUpDown
            // 
            tempUpDown.Anchor = AnchorStyles.None;
            tempUpDown.Font = new Font("Arial", 12F);
            tempUpDown.Location = new Point(86, 38);
            tempUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            tempUpDown.Name = "tempUpDown";
            tempUpDown.Size = new Size(73, 26);
            tempUpDown.TabIndex = 1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F);
            label10.Location = new Point(169, 1);
            label10.Name = "label10";
            label10.Size = new Size(67, 33);
            label10.TabIndex = 2;
            label10.Text = "Pressão (hPa)";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel9.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Controls.Add(DownFreqFix, 0, 0);
            tableLayoutPanel9.Controls.Add(lblDownFreq, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(519, 435);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(262, 102);
            tableLayoutPanel9.TabIndex = 6;
            // 
            // DownFreqFix
            // 
            DownFreqFix.Anchor = AnchorStyles.None;
            DownFreqFix.AutoSize = true;
            DownFreqFix.Font = new Font("Arial", 15F);
            DownFreqFix.Location = new Point(22, 14);
            DownFreqFix.Name = "DownFreqFix";
            DownFreqFix.Size = new Size(217, 23);
            DownFreqFix.TabIndex = 0;
            DownFreqFix.Text = "Frequência Inferior (Hz)";
            // 
            // lblDownFreq
            // 
            lblDownFreq.Anchor = AnchorStyles.None;
            lblDownFreq.AutoSize = true;
            lblDownFreq.BackColor = SystemColors.ControlLightLight;
            lblDownFreq.BorderStyle = BorderStyle.Fixed3D;
            lblDownFreq.Font = new Font("Arial", 15F);
            lblDownFreq.Location = new Point(66, 63);
            lblDownFreq.Name = "lblDownFreq";
            lblDownFreq.Size = new Size(130, 25);
            lblDownFreq.TabIndex = 1;
            lblDownFreq.Text = "Aguardando..";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel7.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(UpFreqFix, 0, 0);
            tableLayoutPanel7.Controls.Add(lblUpFreq, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(519, 327);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(262, 102);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // UpFreqFix
            // 
            UpFreqFix.Anchor = AnchorStyles.None;
            UpFreqFix.AutoSize = true;
            UpFreqFix.Font = new Font("Arial", 15F);
            UpFreqFix.Location = new Point(16, 14);
            UpFreqFix.Name = "UpFreqFix";
            UpFreqFix.Size = new Size(229, 23);
            UpFreqFix.TabIndex = 0;
            UpFreqFix.Text = "Frequência Superior (Hz)";
            // 
            // lblUpFreq
            // 
            lblUpFreq.Anchor = AnchorStyles.None;
            lblUpFreq.AutoSize = true;
            lblUpFreq.BackColor = SystemColors.ControlLightLight;
            lblUpFreq.BorderStyle = BorderStyle.Fixed3D;
            lblUpFreq.Font = new Font("Arial", 15F);
            lblUpFreq.Location = new Point(66, 63);
            lblUpFreq.Name = "lblUpFreq";
            lblUpFreq.Size = new Size(130, 25);
            lblUpFreq.TabIndex = 1;
            lblUpFreq.Text = "Aguardando..";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(DownLimFix, 0, 0);
            tableLayoutPanel6.Controls.Add(lblDownLim, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(261, 435);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(252, 102);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // DownLimFix
            // 
            DownLimFix.Anchor = AnchorStyles.None;
            DownLimFix.AutoSize = true;
            DownLimFix.Font = new Font("Arial", 15F);
            DownLimFix.Location = new Point(39, 14);
            DownLimFix.Name = "DownLimFix";
            DownLimFix.Size = new Size(174, 23);
            DownLimFix.TabIndex = 0;
            DownLimFix.Text = "Limite Inferior (dB)";
            // 
            // lblDownLim
            // 
            lblDownLim.Anchor = AnchorStyles.None;
            lblDownLim.AutoSize = true;
            lblDownLim.BackColor = SystemColors.ControlLightLight;
            lblDownLim.BorderStyle = BorderStyle.Fixed3D;
            lblDownLim.Font = new Font("Arial", 15F);
            lblDownLim.Location = new Point(61, 63);
            lblDownLim.Name = "lblDownLim";
            lblDownLim.Size = new Size(130, 25);
            lblDownLim.TabIndex = 1;
            lblDownLim.Text = "Aguardando..";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(UpLimFix, 0, 0);
            tableLayoutPanel5.Controls.Add(lblUpLim, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(261, 327);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(252, 102);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // UpLimFix
            // 
            UpLimFix.Anchor = AnchorStyles.None;
            UpLimFix.AutoSize = true;
            UpLimFix.Font = new Font("Arial", 15F);
            UpLimFix.Location = new Point(33, 14);
            UpLimFix.Name = "UpLimFix";
            UpLimFix.Size = new Size(186, 23);
            UpLimFix.TabIndex = 0;
            UpLimFix.Text = "Limite Superior (dB)";
            // 
            // lblUpLim
            // 
            lblUpLim.Anchor = AnchorStyles.None;
            lblUpLim.AutoSize = true;
            lblUpLim.BackColor = SystemColors.ControlLightLight;
            lblUpLim.BorderStyle = BorderStyle.Fixed3D;
            lblUpLim.Font = new Font("Arial", 15F);
            lblUpLim.Location = new Point(61, 63);
            lblUpLim.Name = "lblUpLim";
            lblUpLim.Size = new Size(130, 25);
            lblUpLim.TabIndex = 1;
            lblUpLim.Text = "Aguardando..";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(RefLvlFix, 0, 0);
            tableLayoutPanel3.Controls.Add(lblRefLvl, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(261, 219);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(252, 102);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // RefLvlFix
            // 
            RefLvlFix.Anchor = AnchorStyles.None;
            RefLvlFix.AutoSize = true;
            RefLvlFix.Font = new Font("Arial", 15F);
            RefLvlFix.Location = new Point(13, 14);
            RefLvlFix.Name = "RefLvlFix";
            RefLvlFix.Size = new Size(226, 23);
            RefLvlFix.TabIndex = 0;
            RefLvlFix.Text = "Nível de Referência (dB)";
            // 
            // lblRefLvl
            // 
            lblRefLvl.Anchor = AnchorStyles.None;
            lblRefLvl.AutoSize = true;
            lblRefLvl.BackColor = SystemColors.ControlLightLight;
            lblRefLvl.BorderStyle = BorderStyle.Fixed3D;
            lblRefLvl.Font = new Font("Arial", 15F);
            lblRefLvl.Location = new Point(61, 63);
            lblRefLvl.Name = "lblRefLvl";
            lblRefLvl.Size = new Size(130, 25);
            lblRefLvl.TabIndex = 1;
            lblRefLvl.Text = "Aguardando..";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(ParMedFixed, 0, 0);
            tableLayoutPanel2.Controls.Add(lblParMed, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(261, 111);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(252, 102);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // ParMedFixed
            // 
            ParMedFixed.Anchor = AnchorStyles.None;
            ParMedFixed.AutoSize = true;
            ParMedFixed.Font = new Font("Arial", 15F);
            ParMedFixed.Location = new Point(39, 14);
            ParMedFixed.Name = "ParMedFixed";
            ParMedFixed.Size = new Size(174, 23);
            ParMedFixed.TabIndex = 0;
            ParMedFixed.Text = "Parâmetro Medido";
            // 
            // lblParMed
            // 
            lblParMed.Anchor = AnchorStyles.None;
            lblParMed.AutoSize = true;
            lblParMed.BackColor = SystemColors.ControlLightLight;
            lblParMed.BorderStyle = BorderStyle.Fixed3D;
            lblParMed.Font = new Font("Arial", 15F);
            lblParMed.Location = new Point(61, 63);
            lblParMed.Name = "lblParMed";
            lblParMed.Size = new Size(130, 25);
            lblParMed.TabIndex = 1;
            lblParMed.Text = "Aguardando..";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.BackColor = Color.FromArgb(192, 192, 255);
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Controls.Add(tableLayoutPanel26, 0, 0);
            tableLayoutPanel10.Controls.Add(header1, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(261, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(252, 102);
            tableLayoutPanel10.TabIndex = 7;
            // 
            // tableLayoutPanel26
            // 
            tableLayoutPanel26.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel26.ColumnCount = 3;
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel26.Controls.Add(button5, 0, 0);
            tableLayoutPanel26.Controls.Add(button4, 0, 0);
            tableLayoutPanel26.Dock = DockStyle.Fill;
            tableLayoutPanel26.Location = new Point(3, 3);
            tableLayoutPanel26.Name = "tableLayoutPanel26";
            tableLayoutPanel26.RowCount = 1;
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel26.Size = new Size(246, 45);
            tableLayoutPanel26.TabIndex = 3;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Dock = DockStyle.Fill;
            button5.Enabled = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(87, 4);
            button5.Name = "button5";
            button5.Size = new Size(73, 37);
            button5.TabIndex = 10;
            button5.Text = "Indicação de condição de sobrecarga";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Dock = DockStyle.Fill;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(4, 4);
            button4.Name = "button4";
            button4.Size = new Size(76, 37);
            button4.TabIndex = 9;
            button4.Text = "Pulsos Unipolares";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel11.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(CerCalibFix, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 435);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Size = new Size(252, 102);
            tableLayoutPanel11.TabIndex = 9;
            // 
            // CerCalibFix
            // 
            CerCalibFix.Anchor = AnchorStyles.None;
            CerCalibFix.AutoSize = true;
            CerCalibFix.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CerCalibFix.Location = new Point(9, 1);
            CerCalibFix.Name = "CerCalibFix";
            CerCalibFix.Size = new Size(233, 23);
            CerCalibFix.TabIndex = 0;
            CerCalibFix.Text = "Certificado de Calibração";
            CerCalibFix.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(lblDataLbl, 1, 1);
            tableLayoutPanel12.Controls.Add(NúmeroLblFix, 0, 0);
            tableLayoutPanel12.Controls.Add(NumUpDown, 0, 1);
            tableLayoutPanel12.Controls.Add(DataLblFix, 1, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(4, 29);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Size = new Size(244, 69);
            tableLayoutPanel12.TabIndex = 1;
            // 
            // lblDataLbl
            // 
            lblDataLbl.Anchor = AnchorStyles.None;
            lblDataLbl.AutoSize = true;
            lblDataLbl.BackColor = SystemColors.ControlLightLight;
            lblDataLbl.BorderStyle = BorderStyle.Fixed3D;
            lblDataLbl.Font = new Font("Arial", 12F);
            lblDataLbl.Location = new Point(130, 41);
            lblDataLbl.Name = "lblDataLbl";
            lblDataLbl.Size = new Size(104, 20);
            lblDataLbl.TabIndex = 3;
            lblDataLbl.Text = "Aguardando..";
            // 
            // NúmeroLblFix
            // 
            NúmeroLblFix.Anchor = AnchorStyles.None;
            NúmeroLblFix.AutoSize = true;
            NúmeroLblFix.Font = new Font("Arial", 12F);
            NúmeroLblFix.Location = new Point(29, 8);
            NúmeroLblFix.Name = "NúmeroLblFix";
            NúmeroLblFix.Size = new Size(63, 18);
            NúmeroLblFix.TabIndex = 0;
            NúmeroLblFix.Text = "Número";
            NúmeroLblFix.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NumUpDown
            // 
            NumUpDown.Anchor = AnchorStyles.None;
            NumUpDown.Font = new Font("Arial", 12F);
            NumUpDown.Location = new Point(12, 38);
            NumUpDown.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            NumUpDown.Name = "NumUpDown";
            NumUpDown.Size = new Size(98, 26);
            NumUpDown.TabIndex = 1;
            // 
            // DataLblFix
            // 
            DataLblFix.Anchor = AnchorStyles.None;
            DataLblFix.AutoSize = true;
            DataLblFix.Font = new Font("Arial", 12F);
            DataLblFix.Location = new Point(161, 8);
            DataLblFix.Name = "DataLblFix";
            DataLblFix.Size = new Size(42, 18);
            DataLblFix.TabIndex = 2;
            DataLblFix.Text = "Data";
            DataLblFix.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel13.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Controls.Add(tableLayoutPanel15, 0, 1);
            tableLayoutPanel13.Controls.Add(FileSelectFix, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 111);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(252, 102);
            tableLayoutPanel13.TabIndex = 10;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel15.ColumnCount = 2;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.34694F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.65306F));
            tableLayoutPanel15.Controls.Add(lblFilePathAndName, 0, 0);
            tableLayoutPanel15.Controls.Add(btnFileSelect, 1, 0);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(4, 54);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel15.Size = new Size(244, 44);
            tableLayoutPanel15.TabIndex = 2;
            // 
            // lblFilePathAndName
            // 
            lblFilePathAndName.Anchor = AnchorStyles.None;
            lblFilePathAndName.AutoSize = true;
            lblFilePathAndName.BackColor = SystemColors.ControlLightLight;
            lblFilePathAndName.BorderStyle = BorderStyle.Fixed3D;
            lblFilePathAndName.Font = new Font("Arial", 12F);
            lblFilePathAndName.Location = new Point(30, 12);
            lblFilePathAndName.Name = "lblFilePathAndName";
            lblFilePathAndName.Size = new Size(104, 20);
            lblFilePathAndName.TabIndex = 4;
            lblFilePathAndName.Text = "Aguardando..";
            // 
            // btnFileSelect
            // 
            btnFileSelect.BackColor = SystemColors.Highlight;
            btnFileSelect.BackgroundImageLayout = ImageLayout.Zoom;
            btnFileSelect.Dock = DockStyle.Fill;
            btnFileSelect.FlatStyle = FlatStyle.Flat;
            btnFileSelect.Location = new Point(167, 4);
            btnFileSelect.Name = "btnFileSelect";
            btnFileSelect.Size = new Size(73, 36);
            btnFileSelect.TabIndex = 5;
            btnFileSelect.Text = "Selecionar";
            btnFileSelect.UseVisualStyleBackColor = false;
            btnFileSelect.Click += FileSelectBtn_Click;
            // 
            // FileSelectFix
            // 
            FileSelectFix.Anchor = AnchorStyles.None;
            FileSelectFix.AutoSize = true;
            FileSelectFix.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileSelectFix.Location = new Point(36, 14);
            FileSelectFix.Name = "FileSelectFix";
            FileSelectFix.Size = new Size(179, 23);
            FileSelectFix.TabIndex = 1;
            FileSelectFix.Text = "Arquivo Excel Base";
            FileSelectFix.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(524, 9);
            label13.Name = "label13";
            label13.Size = new Size(252, 90);
            label13.TabIndex = 14;
            label13.Text = "Para o correto funcionamento do Software: \r\n- selecione o arquivo excel.\r\n- clique no botão carregar do excel.\r\n- selecione a porta COM.";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label13.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "Nível de Referência (dB)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial", 15F);
            label2.Location = new Point(42, 46);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 1;
            label2.Text = "Carregando";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(label3, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.Size = new Size(200, 100);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 46);
            label3.TabIndex = 0;
            label3.Text = "Frequência Superior (Hz)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Arial", 15F);
            label4.Location = new Point(35, 46);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 1;
            label4.Text = "Aguardando..";
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(label5, 1, 1);
            tableLayoutPanel14.Location = new Point(0, 0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.Size = new Size(200, 100);
            tableLayoutPanel14.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Arial", 15F);
            label5.Location = new Point(106, 26);
            label5.Name = "label5";
            label5.Size = new Size(86, 48);
            label5.TabIndex = 3;
            label5.Text = "Aguardando..";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15F);
            label6.Location = new Point(10, 1);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 0;
            label6.Text = "Número";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel22
            // 
            tableLayoutPanel22.BackColor = Color.FromArgb(192, 192, 255);
            tableLayoutPanel22.ColumnCount = 1;
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel22.Dock = DockStyle.Fill;
            tableLayoutPanel22.Location = new Point(0, 0);
            tableLayoutPanel22.Name = "tableLayoutPanel22";
            tableLayoutPanel22.RowCount = 2;
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel22.Size = new Size(200, 100);
            tableLayoutPanel22.TabIndex = 0;
            // 
            // tableLayoutPanel25
            // 
            tableLayoutPanel25.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel25.ColumnCount = 3;
            tableLayoutPanel25.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel25.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel25.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel25.Dock = DockStyle.Fill;
            tableLayoutPanel25.Location = new Point(0, 0);
            tableLayoutPanel25.Name = "tableLayoutPanel25";
            tableLayoutPanel25.RowCount = 1;
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel25.Size = new Size(200, 100);
            tableLayoutPanel25.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial e de Configurações";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel21.ResumeLayout(false);
            tableLayoutPanel24.ResumeLayout(false);
            tableLayoutPanel27.ResumeLayout(false);
            tableLayoutPanel18.ResumeLayout(false);
            tableLayoutPanel18.PerformLayout();
            tableLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel23.ResumeLayout(false);
            tableLayoutPanel20.ResumeLayout(false);
            tableLayoutPanel20.PerformLayout();
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pressUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)umidUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)tempUpDown).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel26.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumUpDown).EndInit();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label header1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label ParMedFixed;
        private Label lblParMed;
        private TableLayoutPanel tableLayoutPanel3;
        private Label RefLvlFix;
        private Label lblRefLvl;
        private TableLayoutPanel tableLayoutPanel6;
        private Label DownLimFix;
        private Label lblDownLim;
        private TableLayoutPanel tableLayoutPanel5;
        private Label UpLimFix;
        private Label lblUpLim;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel9;
        private Label DownFreqFix;
        private Label lblDownFreq;
        private TableLayoutPanel tableLayoutPanel7;
        private Label UpFreqFix;
        private Label lblUpFreq;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private Label CerCalibFix;
        private TableLayoutPanel tableLayoutPanel12;
        private Label NúmeroLblFix;
        private NumericUpDown NumUpDown;
        private Label DataLblFix;
        private Label lblDataLbl;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel tableLayoutPanel15;
        private Label lblFilePathAndName;
        private Button btnFileSelect;
        private Label FileSelectFix;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label5;
        private Label label6;
        private OpenFileDialog openFileDialog1;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel17;
        private NumericUpDown pressUpDown;
        private NumericUpDown umidUpDown;
        private Label label9;
        private NumericUpDown tempUpDown;
        private Label label10;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel18;
        private Label label12;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel21;
        private TableLayoutPanel tableLayoutPanel24;
        private Button button3;
        private Button button2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel26;
        private TableLayoutPanel tableLayoutPanel22;
        private TableLayoutPanel tableLayoutPanel25;
        private Button button5;
        private Button button4;
        private Button btnExcelToProgram;
        private TableLayoutPanel tableLayoutPanel27;
        private Button btnSaveToExcel;
        private TableLayoutPanel tableLayoutPanel19;
        private Button btnTestGenerator;
        private TableLayoutPanel tableLayoutPanel20;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel23;
        private Button btnUpdate;
        private Label label13;
    }
}
