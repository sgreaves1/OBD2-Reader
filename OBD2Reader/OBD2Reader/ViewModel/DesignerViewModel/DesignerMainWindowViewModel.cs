using OBD2Reader.Model;
using OBD2Reader.Model.DataReceiver;

namespace OBD2Reader.ViewModel.DesignerViewModel
{
    public class DesignerMainWindowViewModel
    {
        public CarModel Car => new CarModel() {Make = "Vauxhall", Model = "Corsa", Year = 2001};

        public DataReceiver DataReceiver => new DataReceiver(null) {IsConnected = true};
    }
}
