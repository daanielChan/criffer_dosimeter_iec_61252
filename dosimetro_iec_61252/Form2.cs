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
    public partial class Form2 : Form
    {

        private screens_manager _screen_manager;
        private Form1 _form1;
        linear_screen lin_scr;
        bool _start_consider_change_event = false;

        int _conf_value = 0;
        string[] ref_values = { "140", "130", "120", "110", "100", "94", "90", "80", "65" };

        public Form2(Form1 form, screens_manager screen_manager)
        {
            _form1 = form;
            _screen_manager = screen_manager;
            InitializeComponent();


            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i < 9; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = ref_values[i];
            }
            _start_consider_change_event = true;
            screen_manager._lin_screen.update_reference_values(ref_values);

            lblConfVal.Text = ref_values[_conf_value];

           if (!screen_manager.have_sheet_configured())
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
                int col_index = e.ColumnIndex;
                int row_index = e.RowIndex;

                var new_value    = dataGridView1.Rows[row_index].Cells[col_index].Value;
                string string_value = Convert.ToString(new_value);

                _screen_manager._lin_screen.public_update_mesaure_value(string_value, row_index, col_index);
                int lastIndex = dataGridView1.Rows.Count - 1;

                _conf_value++;
                if (lastIndex <= _conf_value)
                {
                    _conf_value = 0;
                }

                lblConfVal.Text = ref_values[_conf_value];
            }
        }
    }
}
