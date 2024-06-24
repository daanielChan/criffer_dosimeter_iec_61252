using Microsoft.Extensions.Primitives;
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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dosimetro_iec_61252
{
    public partial class Form2 : Form
    {
        private Form1 _form1;
        private screens_manager _screen_manager;
        private linear_screen lin_scr;

        private double number_adj = 0.00;
        private double[] calibratedVppValues = new double[150];
        private string[] ref_values;

        public Form2(Form1 form, screens_manager screen_manager)
        {
            _form1 = form;
            _screen_manager = screen_manager;
            InitializeComponent();
            tbxAmplAdjust.Enabled = false;

            if (!_screen_manager.have_sheet_configured())
            {
                MessageBox.Show("Você precisa selecionar um arquivo Excel para o correto funcionamento do Software.", "Atenção!");
                return;
            }

            lblRef.Text = _screen_manager._lin_screen.get_ref_val();

            int up_lim = int.Parse(_screen_manager._init_screen._up_lim_db);
            int ref_lvl = int.Parse(_screen_manager._init_screen._ref_level);
            int down_lim = int.Parse(_screen_manager._init_screen._down_lim_db);

            List<int> refValuesList = _screen_manager._lin_screen.reference_arr.Select(int.Parse).ToList();

            if (!refValuesList.Contains(down_lim) && down_lim < refValuesList.Min())
            {
                refValuesList.Add(down_lim);
            }

            if (!refValuesList.Contains(up_lim) && up_lim > refValuesList.Max())
            {
                refValuesList.Add(up_lim);
            }

            if (!refValuesList.Contains(ref_lvl))
            {
                refValuesList.Add(ref_lvl);
            }

            refValuesList.Sort();

            _screen_manager._lin_screen.reference_arr = refValuesList.Select(v => v.ToString()).ToArray();

            ref_values = new string[_screen_manager._lin_screen.reference_arr.Length];
            Array.Copy(_screen_manager._lin_screen.reference_arr, ref_values, _screen_manager._lin_screen.reference_arr.Length);

            dataGridView1.Rows.Clear();
            for (int i = 0; i < ref_values.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = ref_values[i];
            }


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;

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

            lblVpp.Text = _screen_manager._lin_screen.get_vpp();
            tbxAmplAdjust.Text = "0,00";

            _screen_manager._serial.send_data("OUTM0");
            _screen_manager._serial.send_data("MTYP2");
            _screen_manager._serial.send_data("FUNC0");
            _screen_manager._serial.send_data("FREQ1000");
            _screen_manager._serial.send_data("KEYS7");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num_rows = dataGridView1.Rows.Count;
            int num_cols = 4;

            string[][] _vals_matrix = new string[num_rows][];
            for (int i = 0; i < num_rows; i++)
            {
                _vals_matrix[i] = new string[num_cols];
            }

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var new_value = dataGridView1.Rows[i].Cells[j].Value;
                    string string_value = Convert.ToString(new_value);
                    _vals_matrix[i][j] = string_value;
                }
            }
            _screen_manager._lin_screen.update_vpp(lblVpp.Text);
            _screen_manager._lin_screen.public_update_mesaure_value(_vals_matrix, num_rows, num_cols);
        }

        private void cbxAmpAdj_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAmpAdj.Checked == false)
            {
                tbxAmplAdjust.Enabled = false;

                double V94 = double.Parse(lblVpp.Text);

                for (int i = 0; i < ref_values.Length; i++)
                {
                    calibratedVppValues[i] = CalculateVpp(double.Parse(ref_values[i]), double.Parse(lblRef.Text), V94);
                }

                for (int i = 0; i < ref_values.Length; i++)
                {
                    _screen_manager._lin_screen.composed_vpp_dbname[i] = ref_values[i] + " dB \\ " + calibratedVppValues[i].ToString("F4") + " Vpp";
                }

                comboBox1.Items.Clear();

                for (int i = 0; i < ref_values.Length; i++)
                {
                    comboBox1.Items.Add(_screen_manager._lin_screen.composed_vpp_dbname[i]);
                }

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
            else
            {
                tbxAmplAdjust.Enabled = true;
            }
        }

        private double CalculateVpp(double dBSPL, double refDBSPL, double refVpp)
        {
            double Vpp = refVpp * Math.Pow(10, (dBSPL - refDBSPL) / 20);
            return Vpp;
        }

        private void tbxAmplAdjust_KeyDown(object sender, KeyEventArgs e)
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
            int cursor_pos = tbxAmplAdjust.SelectionStart;
            string text = tbxAmplAdjust.Text;

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
            tbxAmplAdjust.Text = number_adj.ToString("F2");
            tbxAmplAdjust.SelectionStart = cursor_pos;
        }

        private void lblVpp_TextChanged(object sender, EventArgs e)
        {
            string newValue = lblVpp.Text;
            newValue = newValue.Replace(',', '.');

            string newString = "AMPL" + newValue + "VP";

            _screen_manager._serial.send_data(newString);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newValue = calibratedVppValues[comboBox1.SelectedIndex].ToString("F4");
            newValue = newValue.Replace(',', '.');

            string newString = "AMPL" + newValue + "VP";

            _screen_manager._serial.send_data(newString);
        }
    }
}