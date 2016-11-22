using System;

namespace OBD2Reader.Model.DataReceiver
{
    public interface IByteSource
    {
        int Read(byte[] bytes);

        void Write(byte[] bytes);

        event EventHandler DataReceived;
    }
}
