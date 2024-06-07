using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dosimetro_iec_61252
{
    public partial class Form2 : Form
    {

        private screens_manager _screen_manager;
        private Form1 _form1;
        linear_screen lin_scr;
        bool _start_consider_change_event = false;

        int _conf_value = 0;

        string[] ref_values = new string[9];
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

            txbVpp.Text = _screen_manager._lin_screen.get_vpp();

            lblRef.Text = _screen_manager._lin_screen.get_ref_val();


            _screen_manager._lin_screen.update_reference_values(ref_values);

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
                comboBox1.Items.Add(_screen_manager._lin_screen.composed_vpp_dbname[i]);
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
             
            _screen_manager._lin_screen.update_vpp(txbVpp.Text);
            _screen_manager._lin_screen.public_update_mesaure_value(_vals_matrix, num_rows, num_cols);
        }

        private void cbxAmpAdj_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAmpAdj.Checked == false)
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
