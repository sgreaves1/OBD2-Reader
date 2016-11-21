namespace OBD2Reader.Model
{
    public class CarModel : BaseModel
    {
        private string _make;
        private string _model;

        public CarModel(string make, string model)
        {
            Make = make;
            Model = model;
        }

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
    }
}
