using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RunningLog
{
    public class App : Application
    {
        public static INavigation Navigation { get; set; }
        public static App Current;

        public static string AppName { get { return "RunningLog"; } }

        public static Page GetMainPage()
        {
            return new Menu.MainPageCS();
        }

        public App()
        {
            Current = this;
            //chiamo il metodo per il settaggio degli styles
            Styles.ResourcesStyle.SetStyles();

            // The root page of your application
            MainPage = new Menu.MainPageCS();

        }

        public static bool EnableBackButton { get; set; }

        public static INavigation GetNavigation()
        {
            return Navigation;
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
            Current = this;
            MainPage = Current.MainPage;
        }
    }
}
