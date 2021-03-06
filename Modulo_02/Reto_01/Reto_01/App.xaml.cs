﻿using Reto_01.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Reto_01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Reto_01.Views.MainView(new MainViewModel());
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
