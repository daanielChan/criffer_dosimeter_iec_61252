using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosimetro_iec_61252
{
    public class init_screen
    {
        public String _par_med;
        public String _com_door;

        public String _ref_level;
        public String _up_lim_db;
        public String _down_lim_db;
        public String _up_lim_freq;
        public String _down_lim_freq;

        public String _umid;
        public String _press;
        public String _temp;
        public String _cert_num;

        public String _cert_data;
        private excel_file_manager excel_file;

        public string _file_name;
        public string _file_path;

        private const String sheet_name_internal = "Config";

        public init_screen ()
        {
            excel_file     = new excel_file_manager();
            _par_med       = string.Empty;
            _com_door      = string.Empty;
            _ref_level     = string.Empty;
            _up_lim_db     = string.Empty;
            _down_lim_db   = string.Empty;
            _up_lim_freq   = string.Empty;
            _down_lim_freq = string.Empty;
            _umid  = string.Empty;
            _press = string.Empty;
            _temp  = string.Empty;
            _cert_num  = string.Empty;
            _cert_data = string.Empty;
            _file_name = string.Empty; 
            _file_path = string.Empty; 
        }

        public void update_from_excel()
        {
            excel_file.init(_file_path, _file_name);

            _par_med       = excel_file.read_cell(sheet_name_internal, 2, 2);
            _ref_level     = excel_file.read_cell(sheet_name_internal, 5, 2);
            _up_lim_db     = excel_file.read_cell(sheet_name_internal, 8, 2);
            _down_lim_db   = excel_file.read_cell(sheet_name_internal, 9, 2);
            _up_lim_freq   = excel_file.read_cell(sheet_name_internal, 6, 2);
            _down_lim_freq = excel_file.read_cell(sheet_name_internal, 7, 2);

            _umid  = excel_file.read_cell(sheet_name_internal, 3, 6);
            _temp  = excel_file.read_cell(sheet_name_internal, 4, 6);
            _press = excel_file.read_cell(sheet_name_internal, 5, 6);

            _cert_num  = excel_file.read_cell(sheet_name_internal, 3, 4);
            _cert_data = excel_file.read_cell(sheet_name_internal, 5, 4);

            if (_umid == "")
            {
                _umid = "0";
            }
            if (_press == "")
            {
                _press = "0";
            }
            if (_temp == "")
            {
                _temp = "0";
            }

            excel_file.close();
        }

        public void update_to_excel ()
        {
            excel_file.init(_file_path, _file_name);
            
            excel_file.write_cell (sheet_name_internal, 3, 6, _umid, false);
            excel_file.write_cell (sheet_name_internal, 4, 6, _temp, false);
            excel_file.write_cell (sheet_name_internal, 5, 6, _press, false);
            excel_file.write_cell (sheet_name_internal, 3, 4, _cert_num, false);

            excel_file.save();
            excel_file.close();
        }
    }
}
