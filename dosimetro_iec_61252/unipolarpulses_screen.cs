using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace dosimetro_iec_61252
{
    public class unipolarpulses_screen
    {
        private excel_file_manager ex_file = new excel_file_manager();

        public string _sheet_name;
        public string _sheet_path;

        private const string sheet_name_internal = "RPU";


        public String expected_laeq = string.Empty;
        public String expected_exposition = string.Empty;

        public string time = string.Empty;

        public unipolarpulses_screen()
        {
            _sheet_name = string.Empty;
            _sheet_path = string.Empty;
        }

        public void update_values()
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty)
            {
                return;
            }

            ex_file.init(_sheet_path, _sheet_name);
            expected_laeq = ex_file.read_cell(sheet_name_internal, 14, 5);
            expected_exposition = ex_file.read_cell(sheet_name_internal, 8, 5);
            time = ex_file.read_cell(sheet_name_internal, 3, 2);
            ex_file.close();
        }

        public void laeq_public_update_mesaure_value(string[][] value, int rows, int cols)
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty)
            {
                return;
            }

            ex_file.init(_sheet_path, _sheet_name);

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    ex_file.write_cell(sheet_name_internal, 14 + i, 2 + j, value[i][j], false);
                }
            }

            
            ex_file.save();
            ex_file.close();
        }


        public void exp_public_update_mesaure_value(string[][] value, int rows, int cols)
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty)
            {
                return;
            }

            ex_file.init(_sheet_path, _sheet_name);

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    ex_file.write_cell(sheet_name_internal, 8 + i, 2 + j, value[i][j], false);
                }
            }
            ex_file.save();
            ex_file.close();
        }

        public string get_vpp()
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty)
            {
                return "";
            }
            string vpp = string.Empty;

            ex_file.init(_sheet_path, _sheet_name);
            vpp = ex_file.read_cell(sheet_name_internal, 2, 2);
            ex_file.close();

            return vpp;
        }

        public void update_vpp(string value)
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty)
            {
                return;
            }

            ex_file.init(_sheet_path, _sheet_name);
            ex_file.write_cell(sheet_name_internal, 2, 2, value);
            ex_file.close();
        }

    }
}
