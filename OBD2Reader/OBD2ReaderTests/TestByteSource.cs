using System;
using OBD2Reader.Model.DataReceiver;

namespace OBD2ReaderTests
{
    public class TestByteSource : IByteSource
    {
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
            throw new NotImplementedException();
        }

        public event EventHandler DataReceived;
        public event EventHandler ConnectionChanged;
    }
}
