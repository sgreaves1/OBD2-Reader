using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OBD2Reader.Model.DataReceiver;

namespace OBD2Reader
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SerialPortSettings Settings { get; set; }

        public SettingsWindow(SerialPortSettings settings)
        {
            Settings = settings;

            InitializeComponent();
        }
    }
}
