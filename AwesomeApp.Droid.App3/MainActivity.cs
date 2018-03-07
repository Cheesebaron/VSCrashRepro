using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using AwesomeApp.Droid.Views;

namespace AwesomeApp.Droid.App3
{
    [Activity(Label = "App3", MainLauncher = true)]
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

