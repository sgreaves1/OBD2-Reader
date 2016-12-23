using System;
using OBD2Reader.ViewModel;

namespace OBD2Reader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private MainWindowViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainWindowViewModel();

            DataContext = viewModel;

            viewModel.SettingsEvent += ViewModelOnSettingsEvent;
        }

        private void ViewModelOnSettingsEvent(object sender, EventArgs eventArgs)
        {
            SettingsWindow window = new SettingsWindow(viewModel.Settings);

            window.ShowDialog();
           
            if (window.DialogResult != null && window.DialogResult.Value)
            {
                 viewModel.Settings = window.Settings;
            }
        }
    }
}
