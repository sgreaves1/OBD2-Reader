using System;
using OBD2Reader.ViewModel;

namespace OBD2Reader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel viewModel = new MainWindowViewModel();

            DataContext = viewModel;

            viewModel.SettingsEvent += ViewModelOnSettingsEvent;
        }

        private void ViewModelOnSettingsEvent(object sender, EventArgs eventArgs)
        {
            
        }
    }
}
