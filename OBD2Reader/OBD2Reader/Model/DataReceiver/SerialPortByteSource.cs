using System;

namespace OBD2Reader.Model.DataReceiver
{
    public class SerialPortByteSource : IByteSource
    {
        public SerialPortByteSource()
        {
            ConnectionChanged?.Invoke(this, EventArgs.Empty);
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
            return false;
        }

        public event EventHandler DataReceived;
        public event EventHandler ConnectionChanged;
    }
}
