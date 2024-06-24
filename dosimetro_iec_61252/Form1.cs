using System.IO.Ports;

namespace dosimetro_iec_61252
{
    public partial class Form1 : Form
    {
        screens_manager _screen_manager = new screens_manager();

        public Form1()
        {
            InitializeComponent();

            string[] ports = null;

            _screen_manager._serial.get_available_coms(ref ports);

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Selecione a Porta!");

            if (ports != null)
            {
                comboBox1.Items.AddRange(ports);
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
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

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void FileSelectBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                lblFilePathAndName.Text = selectedFileName;
                _screen_manager.update_path(Path.GetDirectoryName(openFileDialog1.FileName), openFileDialog1.SafeFileName);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lblFilePathAndName.Text == "Aguardando..")
            {
                MessageBox.Show("Você precisa selecionar um arquivo Excel para carregar os valores.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _screen_manager._init_screen.update_from_excel();

            lblParMed.Text = _screen_manager._init_screen._par_med;
            lblRefLvl.Text = _screen_manager._init_screen._ref_level;
            lblUpLim.Text = _screen_manager._init_screen._up_lim_db;
            lblDownLim.Text = _screen_manager._init_screen._down_lim_db;
            lblUpFreq.Text = _screen_manager._init_screen._up_lim_freq;
            lblDownFreq.Text = _screen_manager._init_screen._down_lim_freq;
            lblDataLbl.Text = _screen_manager._init_screen._cert_data;

            if (_screen_manager._init_screen._umid != null)
            {
                umidUpDown.Value = int.Parse(_screen_manager._init_screen._umid);
            }

            if (_screen_manager._init_screen._temp != null)
            {
                tempUpDown.Value = int.Parse(_screen_manager._init_screen._temp);
            }

            if (_screen_manager._init_screen._press != null)
            {
                pressUpDown.Value = int.Parse(_screen_manager._init_screen._press);
            }

            if (_screen_manager._init_screen._cert_num != null)
            {
                NumUpDown.Value = int.Parse(_screen_manager._init_screen._cert_num);
            }

            MessageBox.Show("Operação Concluída.", "Operação com Arquivo Externo");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lblFilePathAndName.Text == "Aguardando..")
            {
                MessageBox.Show("Você precisa selecionar um arquivo Excel para carregar os valores.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _screen_manager._init_screen._umid = umidUpDown.Value.ToString();
            _screen_manager._init_screen._temp = tempUpDown.Value.ToString();
            _screen_manager._init_screen._press = pressUpDown.Value.ToString();
            _screen_manager._init_screen._cert_num = NumUpDown.Value.ToString();

            _screen_manager._init_screen.update_to_excel();

            MessageBox.Show("Operação Concluída.", "Operação com Arquivo Externo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblParMed.Text == "Aguardando..")
            {
                MessageBox.Show("Clique em carregar do Excel para o correto funcionamento do programa.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form2 tela2 = new Form2(this, _screen_manager);
            tela2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblParMed.Text == "Aguardando..")
            {
                MessageBox.Show("Clique em carregar do Excel para o correto funcionamento do programa.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form3 tela3 = new Form3(this, _screen_manager);
            tela3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (lblParMed.Text == "Aguardando..")
            {
                MessageBox.Show("Clique em carregar do Excel para o correto funcionamento do programa.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (lblParMed.Text == "Exposição")
            {
                Form5 tela5 = new Form5(this, _screen_manager);
                tela5.Show();
                this.Hide();
            }
            else
            {
                Form4 tela4 = new Form4(this, _screen_manager);
                tela4.Show();
                this.Hide();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (lblParMed.Text == "Aguardando..")
            {
                MessageBox.Show("Clique em carregar do Excel para o correto funcionamento do programa.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (lblParMed.Text == "Exposição")
            {
                Form6 tela6 = new Form6(this, _screen_manager);
                tela6.Show();
                this.Hide();
            }
            else
            {
                Form7 tela7 = new Form7(this, _screen_manager);
                tela7.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnTestGenerator_Click(object sender, EventArgs e)
        {
            _screen_manager._serial.send_data("AMPL0.1VP");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                _screen_manager._serial.door = comboBox1.Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] ports = null;

            _screen_manager._serial.get_available_coms(ref ports);

            comboBox1.Items.Clear();
            if (ports != null)
            {
                comboBox1.Items.AddRange(ports);
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
        }
    }
}
