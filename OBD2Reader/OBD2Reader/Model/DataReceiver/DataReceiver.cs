using System;

namespace OBD2Reader.Model.DataReceiver
{
    public class DataReceiver : BaseModel
    {
        private IByteSource _byteSource;

        private bool _isConnected;
        
        public DataReceiver(IByteSource byteSource)
        {
            ByteSource = byteSource;

            ByteSource.DataReceived += ByteSourceOnDataReceived;
            ByteSource.ConnectionChanged += ByteSourceOnConnectionChanged;

            IsConnected = byteSource.IsConnected();
        }

        private void ByteSourceOnConnectionChanged(object sender, EventArgs eventArgs)
        {
            IsConnected = ByteSource.IsConnected();
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

        public bool IsConnected
        {
            get { return _isConnected; }
            set
            {
                _isConnected = value;
                OnPropertyChanged();
            }
        }
    }
}
