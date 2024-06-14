using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace dosimetro_iec_61252
{
    public class excel_file_manager
    {
        private string _file_path;
        private string _file_name;
        private ExcelPackage _package;

        public void init(string file_path, string file_name)
        {
            _file_path = file_path;
            _file_name = file_name;
            _package = new ExcelPackage(new FileInfo(Path.Combine(file_path, file_name)));

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // ou LicenseContext.Commercial
        }

        public void close()
        {
            if (_package != null)
            {
                _package.Dispose();
                _package   = null;
                _file_name = null;
                _file_path = null;
            }
        }

        public string read_cell(string sheet_name, int row, int column)
        {
            if (_package == null)
            {
                throw new InvalidOperationException("initialize the excel_file_manager first by calling init method.");
            }

            ExcelWorksheet worksheet = _package.Workbook.Worksheets[sheet_name];
            if (worksheet == null)
            {
                return "";
            }

            return worksheet.Cells[row, column].Value?.ToString();
        }

        public void write_cell(string sheet_name, int row, int column, string value, bool save = true)
        {
            if (_package == null)
            {
                throw new InvalidOperationException("initialize the excel_file_manager first by calling init method.");
            }

            ExcelWorksheet worksheet = _package.Workbook.Worksheets[sheet_name];
            worksheet.Cells[row, column].Value = value;


            if (save)
            {
                int cont = 0;
                try
                {
                    _package.Save();
                }
                catch (InvalidOperationException)
                {

                    if (cont == 0)
                    {
                        MessageBox.Show("Feche o arquivo Excel antes de salvá-lo.", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cont++;
                    }
                }
                cont = 0;
            }
        }

        public void save()
        {
            if (_package == null)
            {
                throw new InvalidOperationException("initialize the excel_file_manager first by calling init method.");
            }

            try
            {
                _package.Save();
            }
            catch (InvalidOperationException)
            {
                // Exceção de arquivo aberto
                MessageBox.Show("Feche o arquivo Excel antes de salvá-lo.", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
