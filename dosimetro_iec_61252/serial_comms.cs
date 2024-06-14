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
        public string rec_data = string.Empty;
        public string door = string.Empty;

        public serial_comms() 
        { 
        
        }


        public void get_available_coms(ref string[] doors)
        {
            doors = SerialPort.GetPortNames();
        }


        public void send_data(string data)
        {
            if (door == string.Empty)
            {
                return;
            }

            try
            {
                if (_serialPort == null)
                {
                    _serialPort = new SerialPort(door, 9600, Parity.None, 8, StopBits.Two);
                    _serialPort.WriteTimeout = 1000;
                    _serialPort.ReadTimeout = 1000;
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

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (_serialPort != null && _serialPort.IsOpen)
                {
                    rec_data = _serialPort.ReadLine();
                    // Invoke(new Action(() => textBoxReceivedData.AppendText(data + Environment.NewLine)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public string get_data()
        {
            return rec_data;
        }
    }
}
