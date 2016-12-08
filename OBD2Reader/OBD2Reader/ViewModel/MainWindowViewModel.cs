using System;
using System.Windows.Input;
using OBD2Reader.Command;
using OBD2Reader.Model;
using OBD2Reader.Model.DataReceiver;

namespace OBD2Reader.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private CarModel _car;

        private DataReceiver _dataReceiver;

        private SerialPortSettings _settings;

        public MainWindowViewModel()
        {
            Settings = new SerialPortSettings();

            DataReceiver = new DataReceiver(new SerialPortByteSource(Settings));

            Car = new CarModel() { Make = "Vauxhall", Model = "Corsa", Year = 2001};
            
            InitCommands();
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

        public SerialPortSettings Settings
        {
            get { return _settings; }
            set
            {
                _settings = value;
            }
        }

        public event EventHandler SettingsEvent;

        #region Commands
        public ICommand SettingsCommand { get; set; }

        private void InitCommands()
        {
            SettingsCommand = new RelayCommand(MethodToExecute);
        }

        private void MethodToExecute()
        {
            SettingsEvent?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }
}
