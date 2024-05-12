namespace dosimetro_iec_61252
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exemplo de uso:

            // Inicialização
            excel_file_manager excelManager = new excel_file_manager();
            excelManager.init("C:\\Users\\Daniel\\Desktop", "tst.xlsx");

            // Leitura
            string[,] data = excelManager.read_data("Plan1");

            // Escrita
            // excelManager.WriteData(new string[,] { { "A", "B", "C" }, { "1", "2", "3" } }, "Plan2");

            // Fechar o arquivo

            // Converter os dados para uma string legível
            string dataText = "";
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    dataText += data[i, j] + "\t"; // Adiciona o valor e uma tabulação
                }
                dataText += "\n"; // Adiciona uma quebra de linha no final de cada linha de dados
            }

            excelManager.write_cell("Plan2", 2, 3, "Novo Valor");

            excelManager.close();

            // Definir a string formatada como o texto do label1
            label1.Text = dataText;
        }
    }
}
