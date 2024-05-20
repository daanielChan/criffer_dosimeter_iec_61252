namespace dosimetro_iec_61252
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel21 = new TableLayoutPanel();
            tableLayoutPanel26 = new TableLayoutPanel();
            button6 = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            header1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            tbxAmplAdjust = new TextBox();
            tbxRefLevel = new TextBox();
            tbxVpp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbxAmpAdj = new CheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            ValuesColumn = new DataGridViewTextBoxColumn();
            Med1 = new DataGridViewTextBoxColumn();
            Med2 = new DataGridViewTextBoxColumn();
            Med3 = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            lblConfVal = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel21.SuspendLayout();
            tableLayoutPanel26.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(192, 192, 255);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel21, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(cbxAmpAdj, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel21
            // 
            tableLayoutPanel21.BackColor = Color.FromArgb(192, 192, 255);
            tableLayoutPanel21.ColumnCount = 1;
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel21.Controls.Add(tableLayoutPanel26, 0, 0);
            tableLayoutPanel21.Dock = DockStyle.Fill;
            tableLayoutPanel21.Location = new Point(3, 3);
            tableLayoutPanel21.Name = "tableLayoutPanel21";
            tableLayoutPanel21.RowCount = 2;
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel21.Size = new Size(258, 80);
            tableLayoutPanel21.TabIndex = 13;
            // 
            // tableLayoutPanel26
            // 
            tableLayoutPanel26.ColumnCount = 3;
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel26.Controls.Add(button6, 0, 0);
            tableLayoutPanel26.Dock = DockStyle.Fill;
            tableLayoutPanel26.Location = new Point(3, 3);
            tableLayoutPanel26.Name = "tableLayoutPanel26";
            tableLayoutPanel26.RowCount = 1;
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel26.Size = new Size(252, 34);
            tableLayoutPanel26.TabIndex = 3;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.MenuHighlight;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Dock = DockStyle.Fill;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(79, 28);
            button6.TabIndex = 11;
            button6.Text = "Início e Configurações";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.BackColor = Color.FromArgb(192, 192, 255);
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Controls.Add(header1, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(267, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(258, 80);
            tableLayoutPanel10.TabIndex = 7;
            // 
            // header1
            // 
            header1.Anchor = AnchorStyles.None;
            header1.AutoEllipsis = true;
            header1.AutoSize = true;
            header1.BackColor = Color.FromArgb(192, 192, 255);
            header1.Font = new Font("Arial Black", 15F);
            header1.Location = new Point(5, 0);
            header1.Name = "header1";
            header1.Size = new Size(247, 80);
            header1.TabIndex = 0;
            header1.Text = "Teste de Linearlidade e Sinais Estacionários";
            header1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.56589F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.43411F));
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(tbxAmplAdjust, 1, 1);
            tableLayoutPanel2.Controls.Add(tbxRefLevel, 1, 2);
            tableLayoutPanel2.Controls.Add(tbxVpp, 1, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(267, 89);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0741844F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.5192871F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.3323441F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0741844F));
            tableLayoutPanel2.Size = new Size(258, 338);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F);
            label5.Location = new Point(167, 19);
            label5.Name = "label5";
            label5.Size = new Size(84, 46);
            label5.TabIndex = 7;
            label5.Text = "Aguardando..";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F);
            label4.Location = new Point(58, 30);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 6;
            label4.Text = "Nível (dB):";
            // 
            // tbxAmplAdjust
            // 
            tbxAmplAdjust.Anchor = AnchorStyles.Left;
            tbxAmplAdjust.Location = new Point(167, 115);
            tbxAmplAdjust.Name = "tbxAmplAdjust";
            tbxAmplAdjust.Size = new Size(88, 23);
            tbxAmplAdjust.TabIndex = 0;
            // 
            // tbxRefLevel
            // 
            tbxRefLevel.Anchor = AnchorStyles.Left;
            tbxRefLevel.Location = new Point(167, 199);
            tbxRefLevel.Name = "tbxRefLevel";
            tbxRefLevel.Size = new Size(88, 23);
            tbxRefLevel.TabIndex = 1;
            // 
            // tbxVpp
            // 
            tbxVpp.Anchor = AnchorStyles.Left;
            tbxVpp.Location = new Point(167, 283);
            tbxVpp.Name = "tbxVpp";
            tbxVpp.Size = new Size(88, 23);
            tbxVpp.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F);
            label1.Location = new Point(31, 104);
            label1.Name = "label1";
            label1.Size = new Size(130, 46);
            label1.TabIndex = 3;
            label1.Text = "Amplitude de Ajuste (dB):";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F);
            label2.Location = new Point(6, 188);
            label2.Name = "label2";
            label2.Size = new Size(155, 46);
            label2.TabIndex = 4;
            label2.Text = "Nível de Referência (dB):";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F);
            label3.Location = new Point(110, 283);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 5;
            label3.Text = "Vpp:";
            // 
            // cbxAmpAdj
            // 
            cbxAmpAdj.Anchor = AnchorStyles.None;
            cbxAmpAdj.AutoSize = true;
            cbxAmpAdj.Font = new Font("Arial", 15F);
            cbxAmpAdj.Location = new Point(568, 29);
            cbxAmpAdj.Name = "cbxAmpAdj";
            cbxAmpAdj.Size = new Size(192, 27);
            cbxAmpAdj.TabIndex = 16;
            cbxAmpAdj.Text = "Ajustar Amplitude?";
            cbxAmpAdj.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 89);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(258, 338);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ValuesColumn, Med1, Med2, Med3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.DarkBlue;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 15F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(252, 163);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // ValuesColumn
            // 
            ValuesColumn.HeaderText = "Valor";
            ValuesColumn.Name = "ValuesColumn";
            ValuesColumn.ReadOnly = true;
            ValuesColumn.Resizable = DataGridViewTriState.True;
            ValuesColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ValuesColumn.Width = 90;
            // 
            // Med1
            // 
            Med1.HeaderText = "Med#1";
            Med1.Name = "Med1";
            Med1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Med2
            // 
            Med2.HeaderText = "Med#2";
            Med2.Name = "Med2";
            Med2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Med3
            // 
            Med3.HeaderText = "Med#3";
            Med3.Name = "Med3";
            Med3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(lblConfVal, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 172);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(252, 163);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 6);
            label6.Name = "label6";
            label6.Size = new Size(116, 69);
            label6.TabIndex = 0;
            label6.Text = "Valor Configurado:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfVal
            // 
            lblConfVal.Anchor = AnchorStyles.Left;
            lblConfVal.AutoSize = true;
            lblConfVal.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfVal.Location = new Point(129, 17);
            lblConfVal.Name = "lblConfVal";
            lblConfVal.Size = new Size(116, 46);
            lblConfVal.TabIndex = 1;
            lblConfVal.Text = "Aguardando..";
            lblConfVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teste de Linearlidade e Sinais Estacionários";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel21.ResumeLayout(false);
            tableLayoutPanel26.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel21;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel26;
        private Button button6;
        private Label header1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbxAmplAdjust;
        private TextBox tbxRefLevel;
        private TextBox tbxVpp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private CheckBox cbxAmpAdj;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridViewTextBoxColumn ValuesColumn;
        private DataGridViewTextBoxColumn Med1;
        private DataGridViewTextBoxColumn Med2;
        private DataGridViewTextBoxColumn Med3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private Label lblConfVal;
    }
}