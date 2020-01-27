using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HazeRE.Services;
using HazeRE.Views;

namespace HazeRE
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
