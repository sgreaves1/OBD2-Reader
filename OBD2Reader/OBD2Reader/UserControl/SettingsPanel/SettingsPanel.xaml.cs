using System.Collections.ObjectModel;
using System.IO.Ports;
using System.Windows.Input;
using OBD2Reader.Command;

namespace OBD2Reader.UserControl.SettingsPanel
{
    /// <summary>
    /// Interaction logic for SettingsPanel.xaml
    /// </summary>
    public partial class SettingsPanel 
    {
        public SettingsPanel()
        {
            InitializeComponent();

            InitCommands();

            PopulateComPortLists();
        }

        public ObservableCollection<string> ComPortNames { get; set; } = new ObservableCollection<string>();

        public ObservableCollection<string> ComBaudRates { get; set; } = new ObservableCollection<string>();

        public ObservableCollection<string> ComDataBits { get; set; } = new ObservableCollection<string>();

        public ObservableCollection<string> ComStopBits { get; set; } = new ObservableCollection<string>();

        public ObservableCollection<string> ComParities { get; set; } = new ObservableCollection<string>();

        public ObservableCollection<string> ComHandShakes { get; set; } = new ObservableCollection<string>();

        private void PopulateComPortLists()
        {
            ComBaudRates.Add("300");
            ComBaudRates.Add("600");
            ComBaudRates.Add("1200");
            ComBaudRates.Add("2400");
            ComBaudRates.Add("9600");
            ComBaudRates.Add("14400");
            ComBaudRates.Add("19200");
            ComBaudRates.Add("38400");
            ComBaudRates.Add("57600");
            ComBaudRates.Add("115200");

            ComDataBits.Add("5");
            ComDataBits.Add("6");
            ComDataBits.Add("7");
            ComDataBits.Add("8");

            ComStopBits.Add("One");
            ComStopBits.Add("OnePointFive");
            ComStopBits.Add("Two");

            ComParities.Add("None");
            ComParities.Add("Even");
            ComParities.Add("Mark");
            ComParities.Add("Odd");
            ComParities.Add("Space");

            ComHandShakes.Add("None");
            ComHandShakes.Add("XOnXOff");
            ComHandShakes.Add("RequestToSend");
            ComHandShakes.Add("RequestToSendXOnxOff");
        }

        private void RefreshPorts()
        {
            ComPortNames.Clear();

            string[] comNames = SerialPort.GetPortNames();

            foreach (string name in comNames)
            {
                ComPortNames.Add(name);
            }
        }

        public ICommand RefreshPortsCommand { get; set; }

        private void InitCommands()
        {
            RefreshPortsCommand = new RelayCommand(ExecuteRefreshPortsCommand, CanExecuteRefreshPortsCommand);
        }

        private bool CanExecuteRefreshPortsCommand()
        {
            return true;
        }

        private void ExecuteRefreshPortsCommand()
        {
            RefreshPorts();
        }
    }
}
