using System;
using OBD2Reader.Model.SerialPort;

namespace OBD2Reader.Model.DataReceiver
{
    public class DataReceiver
    {
        private IByteSource _byteSource;
        
        public DataReceiver(IByteSource byteSource)
        {
            ByteSource = _byteSource;

            ByteSource.DataReceived += ByteSourceOnDataReceived;
        }

        private void ByteSourceOnDataReceived(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        public IByteSource ByteSource
        {
            get { return _byteSource; }
            set { _byteSource = value; }
        }
    }
}
