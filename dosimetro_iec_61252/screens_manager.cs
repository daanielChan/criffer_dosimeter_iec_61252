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

        public void normalize_voltage(int direction, Label lbl, TextBox tbx, ref double number_adj)
        {
            int cursor_pos = tbx.SelectionStart;
            string text = tbx.Text;

            bool wasNegative = text.StartsWith("-");
            int comma_idx = text.IndexOf(',');

            if (comma_idx != -1)
            {
                double modify = 0.0;
                if (cursor_pos < comma_idx)
                {
                    modify = direction * 1;
                    number_adj += modify;
                }
                else if (cursor_pos == comma_idx + 1)
                {
                    modify = direction * 0.1;
                    number_adj += modify;
                }
                else if (cursor_pos == comma_idx + 2)
                {
                    modify = direction * 0.01;
                    number_adj += modify;
                }

                bool isNegative = number_adj < 0;
                if (wasNegative != isNegative)
                {
                    if (isNegative)
                    {
                        tbx.Text = "-" + (-number_adj).ToString("F2");
                    }
                    else
                    {
                        tbx.Text = number_adj.ToString("F2").TrimStart('-');
                    }

                    if (wasNegative && cursor_pos <= comma_idx + 1)
                    {
                        if (cursor_pos - 1 >= 0)
                        {
                            tbx.SelectionStart = cursor_pos - 1;
                        } else
                        {
                            tbx.SelectionStart = cursor_pos;
                        }
                    }
                    else if (!wasNegative && cursor_pos > comma_idx)
                    {
                        tbx.SelectionStart = cursor_pos + 1;
                    }
                    else
                    {
                        tbx.SelectionStart = cursor_pos;
                    }
                }
                else
                {
                    tbx.Text = number_adj.ToString("F2");
                    tbx.SelectionStart = cursor_pos;
                }

                lbl.Text = calculate_new_vpp(double.Parse(lbl.Text), modify).ToString("F8");
            }

            number_adj = Math.Round(number_adj, 2);
        }
    }
}
