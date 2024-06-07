using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosimetro_iec_61252
{
    public class overload_screen
    {
        private excel_file_manager ex_file = new excel_file_manager();

        public string _sheet_name;
        public string _sheet_path;

        private const string sheet_name_internal = "Sobrecarga";


        public String senoidal_ref_level = string.Empty;
        public String tonal_ref_level = string.Empty;

        public overload_screen()
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
            senoidal_ref_level = ex_file.read_cell(sheet_name_internal, 7, 2);
            tonal_ref_level = ex_file.read_cell(sheet_name_internal, 8, 2);
            ex_file.close();
        }

        public void public_update_mesaure_value(string[][] value, int rows, int cols)
        {
            ex_file.init(_sheet_path, _sheet_name);

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    ex_file.write_cell(sheet_name_internal, 7 + i, 3 + j, value[i][j], false);
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
