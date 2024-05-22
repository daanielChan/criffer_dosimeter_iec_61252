using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosimetro_iec_61252
{
    public class screens_manager
    {
        public init_screen     _init_screen = new init_screen   ();
        public linear_screen   _lin_screen  = new linear_screen ();
        public respfreq_screen _resp_screen = new respfreq_screen ();

        public string _sheet_name = string.Empty;
        public string _sheet_path = string.Empty;

        public screens_manager ()
        {

        }

        public void update_path (string s_p, string s_n)
        {
            _sheet_name = s_n;
            _sheet_path = s_p;

            _init_screen._file_name  = _sheet_name;
            _init_screen._file_path  = _sheet_path;

            _lin_screen._sheet_name  = _sheet_name;
            _lin_screen._sheet_path  = _sheet_path;

            _resp_screen._sheet_path = _sheet_path;
            _resp_screen._sheet_name = _sheet_name;
        }

        public bool have_sheet_configured ()
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty)
            {
                return false;
            } else {
                return true;
            }
        }
    }
}
