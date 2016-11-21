using OBD2Reader.Model;

namespace OBD2Reader.ViewModel.DesignerViewModel
{
    public class DesignerMainWindowViewModel
    {
        public CarModel Car => new CarModel() {Make = "Vauxhall", Model = "Corsa", Year = 2001};
    }
}
