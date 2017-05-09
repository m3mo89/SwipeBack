using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Android.SwipeBackLayout.App;


namespace SwipeBackLayoutSampleApp
{
	[Activity(Label = "SwipeBackLayoutSampleApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : SwipeBackActivity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetTheme(Resource.Style.Theme_AppCompat_Light_NoActionBar);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += delegate { button.Text = $"{count++} clicks!"; };
		}
	}
}

