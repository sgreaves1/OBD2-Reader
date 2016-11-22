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

        public MainWindowViewModel()
        {
            DataReceiver = new DataReceiver(new SerialPortByteSource(new SerialPortSettings() {Name = "Com8"}));

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
