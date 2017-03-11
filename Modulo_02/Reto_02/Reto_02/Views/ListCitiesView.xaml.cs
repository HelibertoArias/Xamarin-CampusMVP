using Reto_02.Models;
using Reto_02.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reto_02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListCitiesView : ContentPage
    {
        public ListCitiesView(ListCitiesViewModel model)
        {
            InitializeComponent();
            BindingContext = model;

            listView.ItemSelected += (sender, e) =>
            {
                var item = e.SelectedItem as CityModel;

                Application.Current.MainPage.Navigation.PushAsync(new DetailCityView(item));
            };
        }
    }
}