using DocumentFormat.OpenXml.Drawing;
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
    public partial class Form3 : Form
    {

        private Form1 _form1;
        private screens_manager _screen_manager;
        private string[] ref_values = new string[8];
        private double number_adj = 0.00;

        public Form3(Form1 form, screens_manager screen_manager)
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

            lblVpp.Text = _screen_manager._resp_screen.get_vpp();
            lblRef.Text = _screen_manager._resp_screen.get_ref_val();

            _screen_manager._resp_screen.update_reference_values(ref_values);

            string up_lim = _screen_manager._init_screen._up_lim_freq;
            string down_lim = _screen_manager._init_screen._down_lim_freq;

            double[] numericValues = ref_values.Select(s => double.Parse(s)).ToArray();
            double upperLimit = double.Parse(up_lim);
            double lowerLimit = double.Parse(down_lim);

            double maiorNumero = numericValues.Max();
            double menorNumero = numericValues.Min();

            if (upperLimit >= maiorNumero)
            {
                if (up_lim == "12500")
                {
                    up_lim = "12589,25";
                }
                ref_values = ref_values.Concat(new[] { up_lim }).ToArray();
            }

            if (lowerLimit <= menorNumero)
            {
                if (down_lim == "31,5")
                {
                    down_lim = "31,62";
                }
                if (down_lim != "63")
                {
                    ref_values = new[] { down_lim }.Concat(ref_values).ToArray();
                }
            }

            for (int i = 0; i < ref_values.Length; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i < ref_values.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = ref_values[i];
            }

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox1.Items.Add(ref_values[i]);
            }

            tbxAmplAdjust.Text = "0,00";
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

            _screen_manager._serial.send_data("OUTM0");
            _screen_manager._serial.send_data("MTYP2");
            _screen_manager._serial.send_data("FUNC0");
            _screen_manager._serial.send_data("FREQ1000");
            _screen_manager._serial.send_data("KEYS6");
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
            int num_cols = 4;

            string[][] _vals_matrix = new string[num_rows][];
            for (int i = 0; i < num_rows; i++)
            {
                _vals_matrix[i] = new string[num_cols];
            }

            for (int j = 0; j < num_cols; j++)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var new_value = dataGridView1.Rows[i].Cells[j].Value;
                    string string_value = Convert.ToString(new_value);
                    _vals_matrix[i][j] = string_value;
                }
            }
            _screen_manager._resp_screen.public_update_mesaure_value(_vals_matrix, num_rows, num_cols);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                tbxAmplAdjust.Enabled = false;

            }
            else
            {
                tbxAmplAdjust.Enabled = true;
            }
        }

        private void tbxAmplAdjust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
            {
                _screen_manager.normalize_voltage(1, lblVpp, tbxAmplAdjust, ref number_adj);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                _screen_manager.normalize_voltage(-1, lblVpp, tbxAmplAdjust, ref number_adj);
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newValue = comboBox1.Text;
            newValue = newValue.Replace(',', '.');

            string newString = "FREQ" + newValue;

            _screen_manager._serial.send_data(newString);
        }

        private void lblVpp_TextChanged(object sender, EventArgs e)
        {
            string newValue = lblVpp.Text;
            newValue = newValue.Replace(',', '.');

            string newString = "AMPL" + newValue + "VP";

            _screen_manager._serial.send_data(newString);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridView1.CurrentCell.RowIndex;
            int nextRowIndex = (currentRowIndex + 1) % dataGridView1.Rows.Count;
            comboBox1.SelectedIndex = nextRowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[nextRowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            save();
            if (_screen_manager._init_screen._par_med == "Exposição")
            {
                Form5 tela5 = new Form5(_form1, _screen_manager);
                tela5.Show();
                this.Hide();
            }
            else
            {
                Form4 tela4 = new Form4(_form1, _screen_manager);
                tela4.Show();
                this.Hide();
            }
        }
    }
}
