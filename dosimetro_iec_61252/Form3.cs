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
        string[] ref_values_0 = { "63,10 Hz", "125,89 Hz", "251,19 Hz", "501,19 Hz", "1000,00 Hz", "1995,26 Hz", "3981,07 Hz", "7943,28 Hz" };
        string[] ref_values = new string[8];
        bool _start_consider_change_event = false;
        int _conf_value = 0;

        public Form3(Form1 form, screens_manager screen_manager)
        {
            _form1 = form;
            _screen_manager = screen_manager;
            InitializeComponent();

            ref_values = ref_values_0;

            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = ref_values[i];
            }

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            screen_manager._resp_screen.update_reference_values(ref_values);

            _start_consider_change_event = true;

            if (!_screen_manager.have_sheet_configured())
            {
                MessageBox.Show("Você precisa selecionar um arquivo Excel para o correto funcionamento do Software.", "Atenção!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Hide(); // Esconde o formulário principal
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_start_consider_change_event == true)
            {
                int lastIndex = dataGridView1.Rows.Count - 1;

                _conf_value++;
                if (lastIndex < _conf_value)
                {
                    _conf_value = 0;
                    lblConfVal.Text = ref_values[_conf_value];
                }
                else
                {
                    lblConfVal.Text = ref_values[_conf_value];
                }
            }
        }

        private void tbxVpp_TextChanged(object sender, EventArgs e)
        {
            if (tbxVpp.Text.Length > 0)
            {
                string temp_val = lblRef.Text + " dB" + " / " + tbxVpp.Text + " Vpp";
                lblLevelRef.Text = temp_val;

                _screen_manager._resp_screen.update_vpp_level(tbxVpp.Text);
            }
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
            _screen_manager._resp_screen.public_update_mesaure_value(_vals_matrix, num_rows, num_cols);
            
        }
    }
}
