using Reto_01.ViewModels.Base;
using System.Windows.Input;
using Xamarin.Forms;

namespace Reto_01.ViewModels
{
    public class CounterViewModel : ViewModelBase
    {
        public CounterViewModel()
        {
            Counter = 0;
            Texto = $"Botón pulsado {Counter} veces";
        }

        private int _counter;

        public int Counter
        {
            get { return _counter; }
            set { _counter = value; }
        }

        private string _texto;

        public string Texto
        {
            get { return _texto; }
            set
            {
                _texto = value;
                OnPropertyChanged();
            }
        }

        private ICommand _pressCommand { get; set; }

        public ICommand PressCommand
        {
            get { return _pressCommand = _pressCommand ?? new Command(IncrementCounter); }
        }

        private void IncrementCounter()
        {
            Counter++;
            Texto = $"Botón pulsado {Counter} veces";
        }
    }
}