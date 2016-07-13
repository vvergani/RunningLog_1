using Android.App;
using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Telephony;
using Android.Widget;
using RunningLog.Interfaces;

[assembly: Dependency(typeof(RunningLog.Droid.Classes.Toast_Android))]

namespace RunningLog.Droid.Classes
{
    public class Toast_Android : IToast
    {
        private static Context Context
        {
            get { return Android.App.Application.Context; }
        }

        public void DisplayToast(string message)
        {

            Toast.MakeText(Context, message, ToastLength.Short).Show();
        }
    }
}