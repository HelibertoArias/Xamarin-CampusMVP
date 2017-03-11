using Reto_01.Models;

namespace Reto_01.ViewModels
{
    public class MainViewModel
    {
        public TipCalModel Model { get; set; }

        public MainViewModel()
        {
            Model = new TipCalModel();
        }
    }
}