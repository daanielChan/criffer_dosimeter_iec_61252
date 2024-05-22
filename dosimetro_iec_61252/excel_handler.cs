using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // ou LicenseContext.Commercial
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

        public void write_data(string[,] data, string sheet_name = "Sheet1")
        {
            if (_package == null)
            {
                throw new InvalidOperationException("initialize the excel_file_manager first by calling init method.");
            }

            ExcelWorksheet worksheet = _package.Workbook.Worksheets.Add(sheet_name);

            int row_count = data.GetLength(0);
            int col_count = data.GetLength(1);

            for (int row = 1; row <= row_count; row++)
            {
                for (int col = 1; col <= col_count; col++)
                {
                    worksheet.Cells[row, col].Value = data[row - 1, col - 1];
                }
            }

            _package.Save();
        }

        public string[,] read_data(string sheet_name = "Sheet1")
        {
            if (_package == null)
            {
                throw new InvalidOperationException("initialize the excel_file_manager first by calling init method.");
            }

            ExcelWorksheet worksheet = _package.Workbook.Worksheets[sheet_name];
            int row_count = worksheet.Dimension.Rows;
            int col_count = worksheet.Dimension.Columns;
            string[,] data = new string[row_count, col_count];

            for (int row = 1; row <= row_count; row++)
            {
                for (int col = 1; col <= col_count; col++)
                {
                    data[row - 1, col - 1] = worksheet.Cells[row, col].Value?.ToString();
                }
            }

            return data;
        }

        public string read_cell(string sheet_name, int row, int column)
        {
            if (_package == null)
            {
                throw new InvalidOperationException("initialize the excel_file_manager first by calling init method.");
            }

            ExcelWorksheet worksheet = _package.Workbook.Worksheets[sheet_name];
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
                _package.Save();
            }
        }

        public void save ()
        {
            if (_package == null)
            {
                throw new InvalidOperationException("initialize the excel_file_manager first by calling init method.");
            }
            _package.Save();
        }
    }
}