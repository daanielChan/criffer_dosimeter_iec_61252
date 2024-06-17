using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosimetro_iec_61252
{
    public class fastpulses_screen
    {
        private excel_file_manager ex_file = new excel_file_manager();
        
        public string _sheet_name;
        public string _sheet_path;

        const int table_size = 4;

        string[] ref_values      = new string[table_size];
        string[] duration        = new string[table_size];
        string[] proportion      = new string[table_size];
        string[] pulse_level     = new string[table_size];
        public string[] time     = new string[table_size];
        string[] calculated_result = new string[table_size];

        public string[] composed_process_name = new string[table_size];

        private const string sheet_name_internal = "RSCD";
       
        public fastpulses_screen()
        {
            _sheet_name = string.Empty;
            _sheet_path = string.Empty;
        }


        public void update_values_exposition()
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty)
            {
                return;
            }

            ex_file.init(_sheet_path, _sheet_name);

            for (int i = 0; i < table_size; i++)
            {
                duration[i]    = ex_file.read_cell(sheet_name_internal, 7 + i, 1);
                proportion[i]  = ex_file.read_cell(sheet_name_internal, 7 + i, 2);
                pulse_level[i] = ex_file.read_cell(sheet_name_internal, 7 + i, 3);
                time[i]        = ex_file.read_cell(sheet_name_internal, 7 + i, 4);
                calculated_result[i] = ex_file.read_cell(sheet_name_internal, 7 + i, 5);

                composed_process_name[i] = duration[i] + "ms \\ " + proportion[i] + " \\ " + pulse_level[i] + " dB \\ " + time[i] + " s \\ E = " + calculated_result[i];
            }
            ex_file.close();
        }

        public void update_values_laeq()
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty)
            {
                return;
            }

            ex_file.init(_sheet_path, _sheet_name);

            for (int i = 0; i < table_size; i++)
            {
                duration[i] = ex_file.read_cell(sheet_name_internal, 15 + i, 1);
                proportion[i] = ex_file.read_cell(sheet_name_internal, 15 + i, 2);
                pulse_level[i] = ex_file.read_cell(sheet_name_internal, 15 + i, 3);
                time[i] = ex_file.read_cell(sheet_name_internal, 15 + i, 4);
                calculated_result[i] = ex_file.read_cell(sheet_name_internal, 15 + i, 5);


                composed_process_name[i] = duration[i] + "ms \\ " + proportion[i] + " \\ " + pulse_level[i] + " dB \\ " + time[i] + " s \\ LAeq = " + calculated_result[i];
           
            }

            ex_file.close();
        }

        public void public_update_mesaure_value(string[][] value, int rows, int cols)
        {
            ex_file.init(_sheet_path, _sheet_name);

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    ex_file.write_cell(sheet_name_internal, 7 + i, 6 + j, value[i][j], false);
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
