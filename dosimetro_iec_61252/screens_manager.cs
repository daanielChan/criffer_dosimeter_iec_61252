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
        public fastpulses_screen _fastpulses = new fastpulses_screen();
        public unipolarpulses_screen _unipolarpulses = new unipolarpulses_screen();
        public overload_screen _overload = new overload_screen();

        public serial_comms _serial = new serial_comms ();

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

            _fastpulses._sheet_path = _sheet_path;
            _fastpulses._sheet_name = _sheet_name;

            _unipolarpulses._sheet_name = _sheet_name;
            _unipolarpulses._sheet_path = _sheet_path;


            _overload._sheet_path = _sheet_path;
            _overload._sheet_name = _sheet_name;
        }

        public bool have_sheet_configured ()
        {
            if (_sheet_name == string.Empty || _sheet_path == string.Empty || _init_screen._down_lim_db == string.Empty /*|| _serial.door == string.Empty*/)
            {
                return false;
            } else {

                return true;
            }
        }

        public double calculate_new_vpp(double reference, double change)
        {
            double exponent = change / 20.0;
            double powerOfTen = Math.Pow(10, exponent);
            double result = reference * powerOfTen;
            return result;
        }
    }
}
