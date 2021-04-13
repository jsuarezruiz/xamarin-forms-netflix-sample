using Android.App;

namespace Xamarin.Netflix.Droid
{
    [Activity(
        Label = "Netflix",
        Icon = "@drawable/icon",
        Theme = "@style/splashscreen",
        MainLauncher = true,
        NoHistory = true)]
    public class SplashActivity : AndroidX.AppCompat.App.AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(MainActivity));
        }
    }
}