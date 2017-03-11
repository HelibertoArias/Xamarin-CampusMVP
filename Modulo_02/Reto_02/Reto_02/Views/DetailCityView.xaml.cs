using Reto_02.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reto_02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailCityView : ContentPage
    {
        public DetailCityView(CityModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}