using Reto_01.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reto_01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CounterView : ContentPage
    {
        public CounterView(CounterViewModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}