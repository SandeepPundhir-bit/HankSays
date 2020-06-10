﻿using HankSays.Views;
using Xamarin.Forms;


namespace HankSays
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StartView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
