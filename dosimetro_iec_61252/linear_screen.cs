using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosimetro_iec_61252
{
    public class linear_screen
    {
        private excel_file_manager ex_file = new excel_file_manager();
            
        public int [][] _table_measurements;
        
        public string _sheet_name;
        public string _sheet_path;
        
        private const string sheet_name_internal = "Lin";
        
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

            if ("140" == ex_file.read_cell(sheet_name_internal, 7, 1))
            {
                ex_file.close();
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                ex_file.write_cell(sheet_name_internal, 7 + i, 1, _tab_meas[i]);
            }

            ex_file.close();
        }

        public void public_update_mesaure_value (string value, int line, int tryout)
        {
            ex_file.init(_sheet_path, _sheet_name);
            ex_file.write_cell(sheet_name_internal, 7 + line, 2 + line, value);
            ex_file.close();
        }
    }
}
