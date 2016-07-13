using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace RunningLog.Droid.Classes
{
	[Activity(Label = "Running Diary", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.Splash",
	 ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Sensor)]
    public class SplashScreenActivity : Activity
	{
		protected override void OnCreate(Bundle bundle) {
			base.OnCreate(bundle);

			var intent = new Intent(this, typeof(MainActivity));
			StartActivity(intent);
			Finish();
		}
	}
}