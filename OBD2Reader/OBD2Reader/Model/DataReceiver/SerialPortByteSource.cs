using System;
using System.IO.Ports;

namespace OBD2Reader.Model.DataReceiver
{
    public class SerialPortByteSource : IByteSource
    {
        private SerialPort _serialPort;

        private readonly byte[] _bytes = new byte[30];
        
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
            // todo: signal what's changed and what state its in
            throw new NotImplementedException();
        }

        private void SerialPortOnDataReceived(object sender, SerialDataReceivedEventArgs serialDataReceivedEventArgs)
        {
            _serialPort?.Read(_bytes, 0, _bytes.Length);

            DataReceived?.Invoke(this, EventArgs.Empty);
        }

        public int Read(byte[] bytes)
        {
            int count;
            for (count = 0; count < _bytes.Length; count++)
            {
                if (count < bytes.Length)
                    bytes[count] = _bytes[count];
            }

            return count;
        }

        public void Write(byte[] bytes)
        {
            // todo: write to the serial port
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
