 using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosimetro_iec_61252
{
    public partial class Form4 : Form
    {
        const int table_size = 4;
        private Form1 _form1;
        private TimeSpan timeRemaining;

        private double number_adj = 0.00;
        private double[] calibratedVppValues = new double[4];

        private screens_manager _screen_manager;

        public Form4(Form1 form, screens_manager screen_manager)
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

            _screen_manager._fastpulses.update_values_laeq();
            lblVpp.Text = _screen_manager._fastpulses.get_vpp();
            lblSigLvl.Text = _screen_manager._fastpulses.db_ref;

            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = _screen_manager._fastpulses.composed_process_name[i];
            }

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;

            for (int i = 0; i < table_size; i++)
            {
                comboBox1.Items.Add(_screen_manager._fastpulses.composed_process_name[i]);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }

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


            tbxAdjust.Text = "0,00";

            _screen_manager._serial.send_data("OUTM0");
            _screen_manager._serial.send_data("MTYP2");
            _screen_manager._serial.send_data("FUNC0");
            _screen_manager._serial.send_data("FREQ4000");
            _screen_manager._serial.send_data("KEYS6");
        }
        private double CalculateVpp(double dBSPL, double refDBSPL, double refVpp)
        {
            double Vpp = refVpp * Math.Pow(10, (dBSPL - refDBSPL) / 20);
            return Vpp;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            save();
            _form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }


        private void save()
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
            _screen_manager._fastpulses.laeq_update_mesaure_value(_vals_matrix, num_rows, num_cols);
            _screen_manager._fastpulses.update_vpp(lblVpp.Text);
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblE4k.Text = _screen_manager._fastpulses.calculated_result[comboBox1.SelectedIndex];

            double parsedValue = double.Parse(_screen_manager._fastpulses.time[comboBox1.SelectedIndex], CultureInfo.InvariantCulture);

            int totalSeconds = (int)parsedValue;

            TimeSpan ts = TimeSpan.FromSeconds(totalSeconds);

            int hours = ts.Hours;
            int minutes = ts.Minutes;
            int seconds = ts.Seconds;


            timeRemaining = new TimeSpan(hours, minutes, seconds);
            lblTime.Text = timeRemaining.ToString(@"hh\:mm\:ss");

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
            // 1o pulso    10ms  1:100  95 
            // 2o pulso    1ms   1:1000 95 
            // 3o pulso    1ms   1:1000 100 
            // 4o pulso    10ms  1:1000 100 

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
                    // corrigir.
                    _screen_manager._serial.send_data("BCNT00040");
                    _screen_manager._serial.send_data("RCNT04000");
                    _screen_manager._serial.send_data("DPTH0PR");
                }
            }
            else
            { // case 2
                if (_screen_manager._fastpulses.pulse_level[comboBox1.SelectedIndex].Contains("95"))
                {
                    _screen_manager._serial.send_data("BCNT00004");
                    _screen_manager._serial.send_data("RCNT04000");
                    _screen_manager._serial.send_data("DPTH0PR");
                }
                else
                { // case 3
                    if (_screen_manager._fastpulses.pulse_level[comboBox1.SelectedIndex].Contains("100"))
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

        private void tbxAdjust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
            {
                _screen_manager.normalize_voltage(1, lblVpp, tbxAdjust, ref number_adj);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                _screen_manager.normalize_voltage(-1, lblVpp, tbxAdjust, ref number_adj);
                e.Handled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            save();
            if (_screen_manager._init_screen._par_med == "Exposição")
            {
                Form6 tela6 = new Form6(_form1, _screen_manager);
                tela6.Show();
                this.Hide();
            }
            else
            {
                Form7 tela7 = new Form7(_form1, _screen_manager);
                tela7.Show();
                this.Hide();
            }
        }
    }
}

