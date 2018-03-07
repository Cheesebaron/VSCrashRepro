using Android.App;
using Android.Widget;
using Android.OS;
using AwesomeApp.Droid.Views;
using Android.Content;

namespace AwesomeApp.Droid.App1
{
    [Activity(Label = "App1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.button);
            button.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(WelcomeView));
                StartActivity(intent);
            };
        }
    }
}

