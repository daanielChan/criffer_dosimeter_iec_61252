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
    public partial class Form4 : Form
    {
        const int table_size = 4;
        private Form1 _form1;

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
            txbVpp.Text = _screen_manager._fastpulses.get_vpp();

            _screen_manager._fastpulses.update_values_exposition();

            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = _screen_manager._fastpulses.composed_process_name[i];
            }

            lblTime.Text = _screen_manager._fastpulses.time[0];

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            // Configurações do comboBox1
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // Impede a edição do texto
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed; // Define o modo de desenho personalizado

            for (int i = 0; i < table_size; i++)
            {
                comboBox1.Items.Add(_screen_manager._fastpulses.composed_process_name[i]);
            }

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

            _screen_manager._fastpulses.update_vpp(txbVpp.Text);
            _screen_manager._fastpulses.public_update_mesaure_value(_vals_matrix, num_rows, num_cols);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Hide(); // Esconde o formulário principal
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTime.Text = _screen_manager._fastpulses.time[comboBox1.SelectedIndex];
        }
    }
}
