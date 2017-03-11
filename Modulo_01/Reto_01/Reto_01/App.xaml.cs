using Reto_01.ViewModels;

using Xamarin.Forms;

namespace Reto_01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Reto_01.Views.CounterView(new CounterViewModel());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}