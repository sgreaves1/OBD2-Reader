using System;
using System.IO.Ports;

namespace OBD2Reader.Model.DataReceiver
{
    public class SerialPortByteSource : IByteSource
    {
        private SerialPort _serialPort;
        
        public SerialPortByteSource(SerialPortSettings settings)
        {
            CreatePort(settings);
        }

        public void CreatePort(SerialPortSettings settings)
        {
            try
            {
                _serialPort = new SerialPort(settings.Name);

                _serialPort.DataReceived += SerialPortOnDataReceived;
                _serialPort.PinChanged += SerialPortOnPinChanged;

                _serialPort.Open();
            }
            catch (Exception e)
            {
                // todo: log exception please.
            }
        }

        private void SerialPortOnPinChanged(object sender, SerialPinChangedEventArgs serialPinChangedEventArgs)
        {
            throw new NotImplementedException();
        }

        private void SerialPortOnDataReceived(object sender, SerialDataReceivedEventArgs serialDataReceivedEventArgs)
        {
            throw new NotImplementedException();
        }

        public int Read(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public void Write(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public bool IsConnected()
        {
            return _serialPort?.IsOpen != null && (bool) _serialPort?.IsOpen;
        }

        public event EventHandler DataReceived;
        public event EventHandler ConnectionChanged;
    }
}
