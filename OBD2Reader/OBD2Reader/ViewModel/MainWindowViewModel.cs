using OBD2Reader.Model;
using OBD2Reader.Model.DataReceiver;

namespace OBD2Reader.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private CarModel _car;

        private DataReceiver _dataReceiver;

        public MainWindowViewModel()
        {
            DataReceiver = new DataReceiver(new SerialPortByteSource(new SerialPortSettings() {Name = "Com8"}));
        }

        public CarModel Car
        {
            get { return _car; }
            set
            {
                _car = value;
                OnPropertyChanged();
            }
        }

        public DataReceiver DataReceiver
        {
            get { return _dataReceiver; }
            set
            {
                _dataReceiver = value;
                OnPropertyChanged();
            }
        }
    }
}
