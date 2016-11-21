using OBD2Reader.Model;

namespace OBD2Reader.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private CarModel _car;

        public CarModel Car
        {
            get { return _car; }
            set
            {
                _car = value;
                OnPropertyChanged();
            }
        }
    }
}
