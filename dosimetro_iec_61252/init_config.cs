using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosimetro_iec_61252
{
    internal class init_config
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

        excel_file_manager excel_file;

        private String sheet_name_internal = "Config";

        public init_config ()
        {
            excel_file = new excel_file_manager();
            _par_med = string.Empty;
            _com_door = string.Empty;
            _ref_level = string.Empty;
            _up_lim_db = string.Empty;
            _down_lim_db = string.Empty;
            _up_lim_freq = string.Empty;
            _down_lim_freq = string.Empty;
            _umid = string.Empty;
            _press = string.Empty;
            _temp = string.Empty;
            _cert_num = string.Empty;
            _cert_data = string.Empty;
        }

        public void update_from_excel(string file_path, string file_name)
        {
            excel_file.init(file_path, file_name);

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

            excel_file.close();
        }

        public void update_to_excel (string file_path, string file_name)
        {
            
            excel_file.init(file_path, file_name);
            
            excel_file.write_cell(sheet_name_internal, 3, 6, _umid);
            excel_file.write_cell(sheet_name_internal, 4, 6, _temp);
            excel_file.write_cell(sheet_name_internal, 5, 6, _press);
            excel_file.write_cell(sheet_name_internal, 3, 4, _cert_num);
            
            excel_file.close();
        }
    }
}
