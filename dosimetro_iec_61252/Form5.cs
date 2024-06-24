using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosimetro_iec_61252
{
    public partial class Form5 : Form
    {
        private const int table_size = 4;
        private Form1 _form1;
        private TimeSpan timeRemaining;
        private TimeSpan time2_remaining;

        private double number_adj = 0.00;

        private screens_manager _screen_manager;
        private double[] calibratedVppValues = new double[4];

        public Form5(Form1 form, screens_manager screen_manager)
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

            lblVpp.Text = _screen_manager._fastpulses.get_vpp();
            _screen_manager._fastpulses.update_values_exposition();
            lblSigLvl.Text = _screen_manager._fastpulses.db_ref;

            for (int i = 0; i < _screen_manager._fastpulses.composed_process_name.Length; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i < _screen_manager._fastpulses.composed_process_name.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = _screen_manager._fastpulses.composed_process_name[i];
            }

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;

            for (int i = 0; i < _screen_manager._fastpulses.composed_process_name.Length; i++)
            {
                comboBox1.Items.Add(_screen_manager._fastpulses.composed_process_name[i]);
            }

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


            // ---- // 
            int totalSeconds = int.Parse(_screen_manager._fastpulses.time[0]);
            TimeSpan ts = TimeSpan.FromSeconds(totalSeconds);
            int hours = ts.Hours;
            int minutes = ts.Minutes;
            int seconds = ts.Seconds;
            timeRemaining = new TimeSpan(hours, minutes, seconds);
            label7.Text = timeRemaining.ToString(@"hh\:mm\:ss");
            // ---- // 


            // ---- //
            TimeSpan ts2 = TimeSpan.FromSeconds(900);
            int hours2 = ts2.Hours;
            int minutes2 = ts2.Minutes;
            int seconds2 = ts2.Seconds;
            time2_remaining = new TimeSpan(hours2, minutes2, seconds2);
            lblContE4k.Text = time2_remaining.ToString(@"hh\:mm\:ss");
            // ---- //

            tbxAdjust.Text = "0,00";

            _screen_manager._serial.send_data("OUTM0");
            _screen_manager._serial.send_data("MTYP2");
            _screen_manager._serial.send_data("FUNC0");
            _screen_manager._serial.send_data("FREQ4000");
            _screen_manager._serial.send_data("KEYS6");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            _screen_manager._fastpulses.public_update_mesaure_value(_vals_matrix, num_rows, num_cols);
        }

        private void cbxAmpAdj_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAmpAdj.Checked == false)
            {
                tbxAdjust.Enabled = false;

                double V94 = double.Parse(lblVpp.Text);


                string[] ref_values = new string[_screen_manager._fastpulses.pulse_level.Length];

                for (int i = 0; i < _screen_manager._fastpulses.pulse_level.Length; i++)
                {
                    ref_values[i] = _screen_manager._fastpulses.pulse_level[i];
                }


                for (int i = 0; i < ref_values.Length; i++)
                {
                    calibratedVppValues[i] = CalculateVpp(double.Parse(ref_values[i]), double.Parse(lblSigLvl.Text), V94);
                }

                _screen_manager._serial.send_data("MENA1");
                update_pulses_generation();
            }
            else
            {
                _screen_manager._serial.send_data("OUTM0");
                _screen_manager._serial.send_data("MTYP2");
                _screen_manager._serial.send_data("FUNC0");
                _screen_manager._serial.send_data("FREQ4000");
                _screen_manager._serial.send_data("MENA0");

                tbxAdjust.Enabled = true;
            }
        }
        private double CalculateVpp(double dBSPL, double refDBSPL, double refVpp)
        {
            double Vpp = refVpp * Math.Pow(10, (dBSPL - refDBSPL) / 20);
            return Vpp;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (!cbxCron.Checked)
            {
                return;
            }
            update_pulses_generation();

            int totalSeconds = int.Parse(_screen_manager._fastpulses.time[comboBox1.SelectedIndex]);

            TimeSpan ts = TimeSpan.FromSeconds(totalSeconds);

            int hours = ts.Hours;
            int minutes = ts.Minutes;
            int seconds = ts.Seconds;

            timeRemaining = new TimeSpan(hours, minutes, seconds);
            label7.Text = timeRemaining.ToString(@"hh\:mm\:ss");

            timer1.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblE4k.Text = _screen_manager._fastpulses.calculated_result[comboBox1.SelectedIndex];

            int totalSeconds = int.Parse(_screen_manager._fastpulses.time[comboBox1.SelectedIndex]);

            TimeSpan ts = TimeSpan.FromSeconds(totalSeconds);

            int hours = ts.Hours;
            int minutes = ts.Minutes;
            int seconds = ts.Seconds;


            timeRemaining = new TimeSpan(hours, minutes, seconds);
            label7.Text = timeRemaining.ToString(@"hh\:mm\:ss");

            update_pulses_generation();
        }


        private void update_pulses_generation()
        {
            if (cbxMeasE4k.Checked)
            {
                return;
            }
            _screen_manager._serial.send_data("FREQ4000");
            _screen_manager._serial.send_data("KEYS6");

            _screen_manager._serial.send_data("OUTE0");
            // 1o pulso    10ms     1:1000 130 5 min    15 min
            // 2o pulso    1ms      1:1000 130 5min	    15 min
            // 3o pulso    1ms      1:1000 125 15min	48 min
            // 4o pulso    10ms     1:100  115 15min	48 min

            // could be the case 1 or 4.
            if (_screen_manager._fastpulses.duration[comboBox1.SelectedIndex] == "10")
            {
                // case 1.
                if (_screen_manager._fastpulses.proportion[comboBox1.SelectedIndex] == "1:1000")
                {
                    _screen_manager._serial.send_data("BCNT00040");
                    _screen_manager._serial.send_data("RCNT40000");
                    _screen_manager._serial.send_data("DPTH0PR");
                }
                else
                { // case 4. 
                    _screen_manager._serial.send_data("BCNT00040");
                    _screen_manager._serial.send_data("RCNT04000");
                    _screen_manager._serial.send_data("DPTH0PR");
                }
            }
            else
            { // case 2
                if (_screen_manager._fastpulses.pulse_level[comboBox1.SelectedIndex].Contains("130"))
                {
                    _screen_manager._serial.send_data("BCNT00004");
                    _screen_manager._serial.send_data("RCNT04000");
                    _screen_manager._serial.send_data("DPTH0PR");
                }
                else
                { // case 3
                    if (_screen_manager._fastpulses.pulse_level[comboBox1.SelectedIndex].Contains("125"))
                    {
                        _screen_manager._serial.send_data("BCNT00004");
                        _screen_manager._serial.send_data("RCNT04000");
                        _screen_manager._serial.send_data("DPTH0PR");
                    }
                    else
                    { // only verify if there are any error.

                        // handle error.
                    }
                }
            }

            string newValue = calibratedVppValues[comboBox1.SelectedIndex].ToString("F4");
            newValue = newValue.Replace(',', '.');

            string newString = "AMPL" + newValue + "VP";

            _screen_manager._serial.send_data(newString);
            _screen_manager._serial.send_data("OUTE1");
        }

        private void lblVpp_TextChanged(object sender, EventArgs e)
        {
            string newValue = lblVpp.Text;
            newValue = newValue.Replace(',', '.');

            string newString = "AMPL" + newValue + "VP";

            _screen_manager._serial.send_data(newString);
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

                lblVpp.Text = _screen_manager.calculate_new_vpp(double.Parse(lblVpp.Text), modify).ToString("F5");
            }

            number_adj = Math.Round(number_adj, 2);
            tbxAdjust.Text = number_adj.ToString("F2");
            tbxAdjust.SelectionStart = cursor_pos;

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (!cbxMeasE4k.Checked)
            {
                return;
            }

            int totalSeconds = 900;

            TimeSpan ts = TimeSpan.FromSeconds(totalSeconds);

            int hours = ts.Hours;
            int minutes = ts.Minutes;
            int seconds = ts.Seconds;

            time2_remaining = new TimeSpan(hours, minutes, seconds);
            lblContE4k.Text = time2_remaining.ToString(@"hh\:mm\:ss");

            timer2.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (time2_remaining > TimeSpan.Zero)
            {
                time2_remaining = time2_remaining.Subtract(TimeSpan.FromSeconds(1));
                lblContE4k.Text = time2_remaining.ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer2.Stop();
                MessageBox.Show("Tempo esgotado!");
            }
        }

        private void cbxMeasE4k_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMeasE4k.Checked)
            {
                _screen_manager._serial.send_data("OUTE0");

                _screen_manager._serial.send_data("OUTM0");
                _screen_manager._serial.send_data("MTYP2");
                _screen_manager._serial.send_data("FUNC0");

                string newValue = lblVpp.Text;
                newValue = newValue.Replace(',', '.');

                string newString = "AMPL" + newValue + "VP";

                _screen_manager._serial.send_data(newString);
            }
            else
            {
                update_pulses_generation();
            }
        }

        private void cbxCron_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxCron.Checked)
            {
                update_pulses_generation();
                timer1.Stop();
                label7.Text = "Cronômetro parado";
                _screen_manager._serial.send_data("OUTE0");
            } else
            {

            }
        }
    }
}

