using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Android.Content;

namespace RunningLog.Droid
{
    [Activity(Label = "RunningLog", Icon = "@drawable/icon", MainLauncher = false, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        Theme = "@style/CustomActionBarTheme")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        private static Context Context
        {
            get { return Android.App.Application.Context; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            string AppName;
            AppName = App.AppName;

            LoadApplication(new App());
        }
        public override void OnBackPressed()
        {
            // This prevents a user from being able to hit the back button and leave the login page..
            if (!RunningLog.App.EnableBackButton) return;

            
                INavigation t;
                t = App.GetNavigation();

                if (t.NavigationStack.Count > 1)
                {
                    App.Navigation.PopAsync();
                }
                else
                {
                    base.OnBackPressed();
                }
           
        }

    }
}

