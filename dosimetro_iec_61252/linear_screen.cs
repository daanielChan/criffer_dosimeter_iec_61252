using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosimetro_iec_61252
{
    public class linear_screen
    {
        private excel_file_manager ex_file = new excel_file_manager();
            
        public int [][] _table_measurements;
        
        public string _sheet_name;
        public string _sheet_path;
        
        private const string sheet_name_internal = "Lin";
        public string[] composed_vpp_dbname = new string [10];
        string[] db_name = new string[10];

        public linear_screen()
        {
            _sheet_name = string.Empty;
            _sheet_path = string.Empty;
            // escrever lógica para mudar automaticamente o nível que está sendo enviado e registrar no excel o valor digitado na tabela.
        }

        public void update_reference_values(string[] _tab_meas)
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty)
            {
                return;
            }

            ex_file.init(_sheet_path, _sheet_name);

            for (int i = 0; i < 9; i++)
            {
                _tab_meas [i] = ex_file.read_cell(sheet_name_internal, 7 + i, 1);
                db_name[i] = _tab_meas[i];

                composed_vpp_dbname[i] = db_name[i] + " / X,XXX Vpp";
            }


            ex_file.close();
        }

        public void public_update_mesaure_value (string [] [] value, int rows, int cols)
        {
            ex_file.init(_sheet_path, _sheet_name);

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    ex_file.write_cell(sheet_name_internal, 7 + i, 2 + j, value[i][j], false);
                }
            }
            ex_file.save();
            ex_file.close();
        }

        public string get_ref_val ()
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty)
            {
                return string.Empty;
            }

            ex_file.init(_sheet_path, _sheet_name);
            string ret_val = ex_file.read_cell(sheet_name_internal, 3, 2);
            ex_file.close();
            return ret_val;
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

        public void update_vpp (string value)
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
