using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using OBD2Reader.Model;

namespace OBD2Reader.UserControl.CarDetails
{
    /// <summary>
    /// Interaction logic for CarDetails.xaml
    /// </summary>
    public partial class CarDetails 
    {
        // Using a DependencyProperty as the backing store for Make.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CarProperty =
            DependencyProperty.Register("Car",
                typeof(CarModel),
                typeof(CarDetails),
                new PropertyMetadata(null));

        public CarDetails()
        {
            InitializeComponent();
        }

        public CarModel Car
        {
            get { return (CarModel)GetValue(CarProperty); }
            set { SetValue(CarProperty, value); }
        }
    }
}
