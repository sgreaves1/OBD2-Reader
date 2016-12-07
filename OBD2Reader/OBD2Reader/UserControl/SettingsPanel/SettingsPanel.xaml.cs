using System;
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
        private ObservableCollection<string> _comPortNames = new ObservableCollection<string>();

        public SettingsPanel()
        {
            InitializeComponent();

            InitCommands();
        }

        public ObservableCollection<string> ComPortNames
        {
            get { return _comPortNames; }
            set { _comPortNames = value; }
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
