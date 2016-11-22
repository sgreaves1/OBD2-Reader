namespace OBD2Reader.Model.DataReceiver
{
    public class SerialPortSettings
    {
        private string _name;

        public SerialPortSettings()
        {
            Name = "COM1";
        }

        /// <summary>
        /// The name of the port to work with.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
