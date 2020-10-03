using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pelican_Pie_Summit.Services;
using Pelican_Pie_Summit.Views;

namespace Pelican_Pie_Summit
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
