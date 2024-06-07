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
        string[] ref_values = new string[10];

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
            txbVpp.Text = _screen_manager._resp_screen.get_vpp();
            lblRef.Text = _screen_manager._resp_screen.get_ref_val();


            _screen_manager._resp_screen.update_reference_values(ref_values);

            for (int i = 0; i < 9; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i < 9; i++)
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
            _screen_manager._resp_screen.update_vpp(txbVpp.Text);
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
    }
}
