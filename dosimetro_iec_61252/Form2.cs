﻿using Microsoft.Extensions.Primitives;
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

        string[] ref_values_094 = { "140 dB", "130 dB", "120 dB", "110 dB", "100 dB", "94 dB", "90 dB", "80 dB", "65 dB" };
        string[] ref_values_114 = { "140 dB", "130 dB", "120 dB", "114 dB", "110 dB", "100 dB", "90 dB", "80 dB", "65 dB" }; 
        string[] ref_values = new string[9];
        public Form2(Form1 form, screens_manager screen_manager)
        {
            _form1 = form;
            _screen_manager = screen_manager;
            InitializeComponent();

            if (_screen_manager._lin_screen.get_ref_val() == "94")
            {
                ref_values = ref_values_094;
            }
            else
            {
                ref_values = ref_values_114;
            }
            lblRef.Text = _screen_manager._lin_screen.get_ref_val();

            string temp_val = lblRef.Text + " dB" + " / " + "0,0" + "Vpp";
            lblLevelRef.Text = temp_val;


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

            _start_consider_change_event = true;
            screen_manager._lin_screen.update_reference_values(ref_values);

            lblConfVal.Text = ref_values[_conf_value];

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
            _screen_manager._lin_screen.public_update_mesaure_value(_vals_matrix, num_rows, num_cols);
        }

        private void tbxVpp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxVpp_Leave(object sender, EventArgs e)
        {
            if (tbxVpp.Text.Length > 0)
            {
                string temp_val = lblRef.Text + " dB" + " / " + tbxVpp.Text + " Vpp";
                lblLevelRef.Text = temp_val;

                _screen_manager._lin_screen.update_vpp_level(tbxVpp.Text);
            }
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            Point mousePosition = this.PointToClient(MousePosition);
            Control control = this.GetChildAtPoint(mousePosition);

            if (control != null && control != tbxVpp)
            {
                this.ActiveControl = null; // Remove o foco de qualquer controle
            }
        }
    }
}
