using Xamarin.Forms;

namespace Reto_02.Models
{
    public class CityModel
    {
        public string Name { get; set; }

        private string _imageName;
        public ImageSource ImagePath { get { return ImageSource.FromResource(_imageName); } }


        public string Description { get; set; }

        public CityModel(string name, string imageName, string description)
        {
            Name = name;
            _imageName = imageName;
            Description = description;
        }
    }
}