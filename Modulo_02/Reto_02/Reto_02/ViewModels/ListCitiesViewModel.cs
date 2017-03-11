using Reto_02.Models;
using System.Collections.ObjectModel;

namespace Reto_02.ViewModels
{
    public class ListCitiesViewModel
    {
        public ObservableCollection<CityModel> Cities { get; set; } = new ObservableCollection<CityModel>();

        public ListCitiesViewModel()
        {
            Cities.Add(new CityModel("New York", "Reto_02.Resources.Images.NewYork.png", "New York City" ));
            Cities.Add(new CityModel("Paris", "Reto_02.Resources.Images.Paris.png", "Paris City"));
            Cities.Add(new CityModel("Roma", "Reto_02.Resources.Images.Roma.png", "Roma City"));
            Cities.Add(new CityModel("San Francisco", "Reto_02.Resources.Images.SanFrancisco.png", "San Francisco City"));
            Cities.Add(new CityModel("Seattle", "Reto_02.Resources.Images.Seattle.png", "Seattle City"));
            Cities.Add(new CityModel("Sevilla", "Reto_02.Resources.Images.Sevilla.png", "Sevilla City"));

        }


    }
}