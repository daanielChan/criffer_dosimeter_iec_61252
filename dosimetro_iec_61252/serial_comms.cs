using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace dosimetro_iec_61252
{
    public class serial_comms
    {

        private SerialPort _serialPort;

        public serial_comms() 
        { 
        
        }


        public void get_available_coms(ref string[] doors)
        {
            doors = SerialPort.GetPortNames();
        }


        public void send_data(string door, string data)
        {
            try
            {
                if (_serialPort == null)
                {
                    _serialPort = new SerialPort(door, 9600, Parity.None, 8, StopBits.One);
                }

                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }

                _serialPort.WriteLine(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (_serialPort != null && _serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
            }
        }
    }
}
