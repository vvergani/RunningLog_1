using System;
using System.Collections.Generic;
using System.Text;
//using ToastIOS;
using Xamarin.Forms;
using RunningLog.Interfaces;

[assembly: Dependency(typeof(RunningLog.iOS.Classes.Toast_iOS))]

namespace RunningLog.iOS.Classes
{
    public class Toast_iOS : IToast
    {
        public void DisplayToast(string message)
        {
            nint duration = new nint(4000);
            //Toast.MakeText(message, duration).Show();
        }

    }
}
