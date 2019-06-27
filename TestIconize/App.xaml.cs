using System;
using TestIconize.ViewModels;
using Xamarin.Forms;
using TestIconize.Views;

namespace TestIconize
{
    public partial class App : Application
    {

        public App()
        {
            Plugin.Iconize.Iconize
                .With(new Plugin.Iconize.Fonts.FontAwesomeRegularModule())
                .With(new Plugin.Iconize.Fonts.FontAwesomeSolidModule());
          
            InitializeComponent();

            MainPage = new MainPage { BindingContext = new MainPageViewModel() };
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
