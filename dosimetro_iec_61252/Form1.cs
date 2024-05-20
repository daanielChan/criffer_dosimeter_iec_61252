namespace dosimetro_iec_61252
{
    public partial class Form1 : Form
    {
        screens_manager screen_manager = new screens_manager();

        public Form1()
        {
            InitializeComponent();
        }

        private void FileSelectBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                lblFilePathAndName.Text = selectedFileName;
                screen_manager.update_path(Path.GetDirectoryName(openFileDialog1.FileName), openFileDialog1.SafeFileName);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lblFilePathAndName.Text == "Aguardando..")
            {
                MessageBox.Show("Voc� precisa selecionar um arquivo Excel para carregar os valores.", "Aten��o!");
                return;
            }

            screen_manager._init_screen.update_from_excel();

            lblParMed.Text   = screen_manager._init_screen._par_med;
            lblRefLvl.Text   = screen_manager._init_screen._ref_level;
            lblUpLim.Text    = screen_manager._init_screen._up_lim_db;
            lblDownLim.Text  = screen_manager._init_screen._down_lim_db;
            lblUpFreq.Text   = screen_manager._init_screen._up_lim_freq;
            lblDownFreq.Text = screen_manager._init_screen._down_lim_freq;
            lblDataLbl.Text  = screen_manager._init_screen._cert_data;

            if (screen_manager._init_screen._umid != null)
            {
                umidUpDown.Value = int.Parse(screen_manager._init_screen._umid);
            }

            if (screen_manager._init_screen._temp != null)
            {
                tempUpDown.Value = int.Parse(screen_manager._init_screen._temp);
            }

            if (screen_manager._init_screen._press != null)
            {
                pressUpDown.Value = int.Parse(screen_manager._init_screen._press);
            }

            if (screen_manager._init_screen._cert_num != null)
            {
                NumUpDown.Value = int.Parse(screen_manager._init_screen._cert_num);
            }
            MessageBox.Show("Opera��o Conclu�da!", "Opera��o com Arquivo Externo");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lblFilePathAndName.Text == "Aguardando..")
            {
                MessageBox.Show("Voc� precisa selecionar um arquivo Excel para salvar os valores.", "Aten��o!");
                return;
            }

            screen_manager._init_screen._umid     = umidUpDown.Value.ToString();
            screen_manager._init_screen._temp     = tempUpDown.Value.ToString();
            screen_manager._init_screen._press    = pressUpDown.Value.ToString();
            screen_manager._init_screen._cert_num = NumUpDown.Value.ToString();

            screen_manager._init_screen.update_to_excel();

            MessageBox.Show("Opera��o Conclu�da!", "Opera��o com Arquivo Externo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2(this, screen_manager);
            tela2.Show();
            this.Hide(); // Esconde o formul�rio principal
        }
    }
}
