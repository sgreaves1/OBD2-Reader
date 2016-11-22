using System;

namespace OBD2Reader.Model.SerialPort
{
    public interface IByteSource
    {
        int Read(byte[] bytes);

        void Write(byte[] bytes);

        event EventHandler DataReceived;
    }
}
