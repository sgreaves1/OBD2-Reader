namespace OBD2Reader.Model
{
    public class CarModel : BaseModel
    {
        private string _make;
        private string _model;
        private int _year;
        
        public string Make
        {
            get { return _make; }
            set
            {
                _make = value;
                OnPropertyChanged();
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
                OnPropertyChanged();
            }
        }

        public int Year
        {
            get { return _year;}
            set
            {
                _year = value;
                OnPropertyChanged();
            }
        }
    }
}
