﻿namespace dosimetro_iec_61252
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel21 = new TableLayoutPanel();
            tableLayoutPanel26 = new TableLayoutPanel();
            button6 = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            header1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label4 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            tbxAmplAdjust = new TextBox();
            label1 = new Label();
            label3 = new Label();
            lblRef = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            ValuesColumn = new DataGridViewTextBoxColumn();
            Med1 = new DataGridViewTextBoxColumn();
            Med2 = new DataGridViewTextBoxColumn();
            Med3 = new DataGridViewTextBoxColumn();
            txbVpp = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel21.SuspendLayout();
            tableLayoutPanel26.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(192, 192, 255);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.875F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.125F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel21, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
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
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel21
            // 
            tableLayoutPanel21.BackColor = Color.FromArgb(192, 192, 255);
            tableLayoutPanel21.ColumnCount = 1;
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel21.Controls.Add(tableLayoutPanel26, 0, 0);
            tableLayoutPanel21.Controls.Add(tableLayoutPanel5, 0, 1);
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
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(button1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 43);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(252, 34);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(120, 28);
            button1.TabIndex = 12;
            button1.Text = "Salvar Excel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            tableLayoutPanel10.Size = new Size(481, 80);
            tableLayoutPanel10.TabIndex = 7;
            // 
            // header1
            // 
            header1.Anchor = AnchorStyles.None;
            header1.AutoEllipsis = true;
            header1.AutoSize = true;
            header1.BackColor = Color.FromArgb(192, 192, 255);
            header1.Font = new Font("Arial Black", 15F);
            header1.Location = new Point(51, 26);
            header1.Name = "header1";
            header1.Size = new Size(379, 28);
            header1.TabIndex = 0;
            header1.Text = "Teste de Resposta em Frequência";
            header1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(lblRef, 1, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(txbVpp, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(267, 89);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0741844F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.5192871F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.3323441F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0741844F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(481, 338);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label4, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            tableLayoutPanel7.Size = new Size(258, 78);
            tableLayoutPanel7.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F);
            label4.Location = new Point(106, 26);
            label4.Name = "label4";
            label4.Size = new Size(149, 22);
            label4.TabIndex = 6;
            label4.Text = "Frequência (Hz):";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(comboBox1, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(267, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            tableLayoutPanel6.Size = new Size(211, 78);
            tableLayoutPanel6.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.Font = new Font("Arial", 13F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 27);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "115,122 \\ 0,1234 vpp";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(checkBox1, 1, 0);
            tableLayoutPanel8.Controls.Add(tbxAmplAdjust, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(267, 87);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(211, 80);
            tableLayoutPanel8.TabIndex = 13;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 15F);
            checkBox1.Location = new Point(108, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 27);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Ajustar Amplitude?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tbxAmplAdjust
            // 
            tbxAmplAdjust.Anchor = AnchorStyles.Left;
            tbxAmplAdjust.Font = new Font("Arial", 14F);
            tbxAmplAdjust.Location = new Point(3, 25);
            tbxAmplAdjust.Name = "tbxAmplAdjust";
            tbxAmplAdjust.Size = new Size(88, 29);
            tbxAmplAdjust.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F);
            label1.Location = new Point(36, 116);
            label1.Name = "label1";
            label1.Size = new Size(225, 22);
            label1.TabIndex = 3;
            label1.Text = "Amplitude de Ajuste (dB):";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F);
            label3.Location = new Point(211, 284);
            label3.Name = "label3";
            label3.Size = new Size(50, 22);
            label3.TabIndex = 5;
            label3.Text = "Vpp:";
            // 
            // lblRef
            // 
            lblRef.Anchor = AnchorStyles.Left;
            lblRef.AutoSize = true;
            lblRef.Font = new Font("Arial", 15F);
            lblRef.Location = new Point(267, 199);
            lblRef.Name = "lblRef";
            lblRef.Size = new Size(128, 23);
            lblRef.TabIndex = 8;
            lblRef.Text = "Aguardando..";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(37, 200);
            label2.Name = "label2";
            label2.Size = new Size(224, 22);
            label2.TabIndex = 4;
            label2.Text = "Nível de Referência (dB):";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 89);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 91.71597F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.284023F));
            tableLayoutPanel3.Size = new Size(258, 338);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ValuesColumn, Med1, Med2, Med3 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.DarkBlue;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Arial", 15F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.Size = new Size(252, 303);
            dataGridView1.TabIndex = 14;
            // 
            // ValuesColumn
            // 
            ValuesColumn.HeaderText = "Valor";
            ValuesColumn.Name = "ValuesColumn";
            ValuesColumn.ReadOnly = true;
            ValuesColumn.Resizable = DataGridViewTriState.True;
            ValuesColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ValuesColumn.Width = 125;
            // 
            // Med1
            // 
            Med1.HeaderText = "Med#1";
            Med1.Name = "Med1";
            Med1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Med1.Width = 88;
            // 
            // Med2
            // 
            Med2.HeaderText = "Med#2";
            Med2.Name = "Med2";
            Med2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Med2.Width = 88;
            // 
            // Med3
            // 
            Med3.HeaderText = "Med#3";
            Med3.Name = "Med3";
            Med3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Med3.Width = 88;
            // 
            // txbVpp
            // 
            txbVpp.Anchor = AnchorStyles.Left;
            txbVpp.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbVpp.Location = new Point(267, 280);
            txbVpp.Name = "txbVpp";
            txbVpp.Size = new Size(88, 29);
            txbVpp.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teste de Resposta em Frequência";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel21.ResumeLayout(false);
            tableLayoutPanel26.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel21;
        private TableLayoutPanel tableLayoutPanel26;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel10;
        private Label header1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblRef;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ValuesColumn;
        private DataGridViewTextBoxColumn Med1;
        private DataGridViewTextBoxColumn Med2;
        private DataGridViewTextBoxColumn Med3;
        private TableLayoutPanel tableLayoutPanel8;
        private CheckBox checkBox1;
        private TextBox tbxAmplAdjust;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel6;
        private ComboBox comboBox1;
        private TextBox txbVpp;
    }
}