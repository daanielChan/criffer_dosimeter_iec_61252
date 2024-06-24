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
        private double number_adj = 0.00;

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

            lblVpp.Text = _screen_manager._unipolarpulses.get_vpp();

            _screen_manager._unipolarpulses.update_values();

            lblSigLvl.Text = _screen_manager._unipolarpulses.ref_level;

            for (int i = 0; i < 2; i++)
            {
                dataGridView1.Rows.Add();
            }

            dataGridView1.Rows[0].Cells[0].Value = "Pulso Negativo / Exposição = " + screen_manager._unipolarpulses.expected_exposition + " Pa2h";
            dataGridView1.Rows[1].Cells[0].Value = "Pulso Positivo / Exposição = " + screen_manager._unipolarpulses.expected_exposition + " Pa2h";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;

            comboBox1.Items.Add("Negativo");
            comboBox1.Items.Add("Positivo");

            comboBox1.SelectedIndex = 0;

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


            timeRemaining = new TimeSpan(hours, minutes, seconds);
            label7.Text = timeRemaining.ToString(@"hh\:mm\:ss");
            tbxAdjust.Text = "0,00";

            _screen_manager._serial.send_data("OUTM0");
            _screen_manager._serial.send_data("MTYP2");
            _screen_manager._serial.send_data("FUNC0");
            _screen_manager._serial.send_data("FREQ1000");
            _screen_manager._serial.send_data("KEYS6");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Hide();
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

            _screen_manager._unipolarpulses.exp_public_update_mesaure_value(_vals_matrix, num_rows, num_cols);
        }

        private void cbxAmpAdj_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAmpAdj.Checked == false)
            {
                tbxAdjust.Enabled = false;
                _screen_manager._serial.send_data("MENA1");
                update_pulses_generation();
            }
            else
            {
                _screen_manager._serial.send_data("OUTM0");
                _screen_manager._serial.send_data("MTYP2");
                _screen_manager._serial.send_data("FUNC0");
                _screen_manager._serial.send_data("FREQ1000");

                _screen_manager._serial.send_data("MENA0");
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
                _screen_manager._serial.send_data("OUTE0");
                timer1.Stop();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                return;
            }
            update_pulses_generation();

            double totalSeconds = double.Parse(_screen_manager._unipolarpulses.time);

            TimeSpan ts = TimeSpan.FromSeconds(totalSeconds);

            int hours = ts.Hours;
            int minutes = ts.Minutes;
            int seconds = ts.Seconds;

            timeRemaining = new TimeSpan(hours, minutes, seconds);
            label7.Text = timeRemaining.ToString(@"hh\:mm\:ss");

            timer1.Start();
        }

        private void tbxAdjust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
            {
                AdjustNumber(1);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                AdjustNumber(-1);
                e.Handled = true;
            }
        }

        private void AdjustNumber(int direction)
        {
            int cursor_pos = tbxAdjust.SelectionStart;
            string text = tbxAdjust.Text;

            int comma_idx = text.IndexOf(',');

            if (comma_idx != -1)
            {
                double modify = 0.0;
                if (cursor_pos < comma_idx)
                {
                    modify = direction * 1;
                    number_adj += modify;
                }
                else if (cursor_pos == comma_idx + 1)
                {
                    modify = direction * 0.1;
                    number_adj += modify;
                }
                else if (cursor_pos == comma_idx + 2)
                {
                    modify = direction * 0.01;
                    number_adj += modify;
                }

                lblVpp.Text = _screen_manager.calculate_new_vpp(double.Parse(lblVpp.Text), modify).ToString("F4");
            }

            number_adj = Math.Round(number_adj, 2);
            tbxAdjust.Text = number_adj.ToString("F2");
            tbxAdjust.SelectionStart = cursor_pos;
        }

        private void lblVpp_TextChanged(object sender, EventArgs e)
        {
            string newValue = lblVpp.Text;
            newValue = newValue.Replace(',', '.');

            string newString = "AMPL" + newValue + "VP";

            _screen_manager._serial.send_data(newString);
        }

        private void update_pulses_generation()
        {
            if (checkBox1.Checked)
            {
                return;
            }

            _screen_manager._serial.send_data("FREQ1000");
            _screen_manager._serial.send_data("KEYS6");

            _screen_manager._serial.send_data("OUTE0");

            _screen_manager._serial.send_data("FUNC1");
            _screen_manager._serial.send_data("BCNT.5");
            _screen_manager._serial.send_data("RCNT00005");
            _screen_manager._serial.send_data("DPTH0PR");

            string newValue = lblVpp.Text;
            newValue = newValue.Replace(',', '.');

            string newString = "AMPL" + newValue + "VP";

            _screen_manager._serial.send_data(newString);
            _screen_manager._serial.send_data("OUTE1");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                update_pulses_generation();
                timer1.Stop();
                label7.Text = "Cronômetro parado";
                _screen_manager._serial.send_data("OUTE0");
            }
            else
            {

            }
        }
    }
}
