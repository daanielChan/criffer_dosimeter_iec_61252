namespace dosimetro_iec_61252
{
    public partial class Form1 : Form
    {
        init_config init_screen = new init_config();

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
                FilePathAndName.Text = selectedFileName;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (FilePathAndName.Text == "Aguardando..")
            {
                MessageBox.Show("Você precisa selecionar um arquivo Excel para carregar os valores.", "Atenção!");
                return;
            }

            init_screen.update_from_excel(Path.GetDirectoryName(openFileDialog1.FileName), openFileDialog1.SafeFileName);

            ParMed.Text   = init_screen._par_med;
            RefLvl.Text   = init_screen._ref_level;
            UpLim.Text    = init_screen._up_lim_db;
            DownLim.Text  = init_screen._down_lim_db;
            UpFreq.Text   = init_screen._up_lim_freq;
            DownFreq.Text = init_screen._down_lim_freq;
            DataLbl.Text  = init_screen._cert_data;

            if (init_screen._umid != null)
            {
                umidUpDown.Value = int.Parse(init_screen._umid);
            }

            if (init_screen._temp != null)
            {
                tempUpDown.Value = int.Parse(init_screen._temp);
            }

            if (init_screen._press != null)
            {
                pressUpDown.Value = int.Parse(init_screen._press);
            }

            if (init_screen._cert_num != null)
            {
                NumUpDown.Value = int.Parse(init_screen._cert_num);
            }
        }

        private void NumUpDown_ValueChanged(object sender, EventArgs e) { }

        private void button7_Click(object sender, EventArgs e)
        {
            if (FilePathAndName.Text == "Aguardando..")
            {
                MessageBox.Show("Você precisa selecionar um arquivo Excel para salvar os valores.", "Atenção!");
                return;
            }

            init_screen._umid  = umidUpDown.Value.ToString();
            init_screen._temp  = tempUpDown.Value.ToString();
            init_screen._press = pressUpDown.Value.ToString();
            init_screen._cert_num = NumUpDown.Value.ToString();

            init_screen.update_to_excel(Path.GetDirectoryName(openFileDialog1.FileName), openFileDialog1.SafeFileName);

        }
    }
}
