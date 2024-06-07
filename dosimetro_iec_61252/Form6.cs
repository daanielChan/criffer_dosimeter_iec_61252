using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosimetro_iec_61252
{
    public partial class Form6 : Form
    {
        private Form1 _form1;
        private screens_manager _screen_manager;
        private TimeSpan timeRemaining;

        public Form6(Form1 form, screens_manager screen_manager)
        {
            _form1 = form;
            _screen_manager = screen_manager;
            InitializeComponent();
            tbxAdjust.Enabled = false;

            if (!_screen_manager.have_sheet_configured())
            {
                MessageBox.Show("Você precisa selecionar um arquivo Excel para o correto funcionamento do Software.", "Atenção!");
                return;
            }

            txbVpp.Text = _screen_manager._unipolarpulses.get_vpp();

            _screen_manager._unipolarpulses.update_values();

            for (int i = 0; i < 2; i++)
            {
                dataGridView1.Rows.Add();
            }

            dataGridView1.Rows[0].Cells[0].Value = "Pulso Negativo // Exposição = " + screen_manager._unipolarpulses.expected_exposition + " Pa2h";
            dataGridView1.Rows[1].Cells[0].Value = "Pulso Positivo // Exposição = " + screen_manager._unipolarpulses.expected_exposition + " Pa2h";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // Impede a edição do texto
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed; // Define o modo de desenho personalizado

            comboBox1.Items.Add("Negativo");
            comboBox1.Items.Add("Positivo");

            comboBox1.SelectedIndex = 0; // Define o primeiro item como selecionado por padrão

            comboBox1.DrawItem += (sender, e) =>
            {
                if (e.Index < 0)
                    return;

                e.DrawBackground();
                string text = comboBox1.Items[e.Index].ToString();
                using (StringFormat sf = new StringFormat())
                {
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds, sf);
                }
            };

            double totalSeconds = double.Parse(_screen_manager._unipolarpulses.time);

            TimeSpan ts = TimeSpan.FromSeconds(totalSeconds);

            int hours = ts.Hours;
            int minutes = ts.Minutes;
            int seconds = ts.Seconds;

            label7.Text = hours + ":" + minutes + ":" + seconds;
            timeRemaining = new TimeSpan(hours, minutes, seconds);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Hide(); // Esconde o formulário principal
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num_rows = dataGridView1.Rows.Count;
            int num_cols = 3;

            string[][] _vals_matrix = new string[num_rows][];
            for (int i = 0; i < num_rows; i++)
            {
                _vals_matrix[i] = new string[num_cols];
            }

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var new_value = dataGridView1.Rows[i].Cells[j + 1].Value;
                    string string_value = Convert.ToString(new_value);
                    _vals_matrix[i][j] = string_value;
                }

            }

            _screen_manager._unipolarpulses.update_vpp(txbVpp.Text);
            _screen_manager._unipolarpulses.exp_public_update_mesaure_value(_vals_matrix, num_rows, num_cols);
        }

        private void cbxAmpAdj_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAmpAdj.Checked == false)
            {
                tbxAdjust.Enabled = false;
            }
            else
            {
                tbxAdjust.Enabled = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining > TimeSpan.Zero)
            {
                timeRemaining = timeRemaining.Subtract(TimeSpan.FromSeconds(1));
                label7.Text = timeRemaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Tempo esgotado!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double totalSeconds = double.Parse(_screen_manager._unipolarpulses.time);

            TimeSpan ts = TimeSpan.FromSeconds(totalSeconds);

            int hours = ts.Hours;
            int minutes = ts.Minutes;
            int seconds = ts.Seconds;

            label7.Text = hours + ":" + minutes + ":" + seconds;
            timeRemaining = new TimeSpan(hours, minutes, seconds);

            timer1.Start();
        }
    }
}
