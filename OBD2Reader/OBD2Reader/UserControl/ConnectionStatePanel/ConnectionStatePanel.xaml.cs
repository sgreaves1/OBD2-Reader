using System.Windows;

namespace OBD2Reader.UserControl.ConnectionStatePanel
{
    /// <summary>
    /// Interaction logic for ConnectionStatePanel.xaml
    /// </summary>
    public partial class ConnectionStatePanel 
    {
        // Using a DependencyProperty as the backing store for IsConnected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsConnectedProperty =
            DependencyProperty.Register("IsConnected", 
                typeof(bool), 
                typeof(ConnectionStatePanel), 
                new PropertyMetadata(false));
        
        public ConnectionStatePanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsConnected
        {
            get { return (bool)GetValue(IsConnectedProperty); }
            set { SetValue(IsConnectedProperty, value); }
        }
    }
}
