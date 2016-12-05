using Android.App;
using Android.Widget;
using Android.OS;

namespace Jackpotter
{
	[Activity(Label = "Jackpotter", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button1 = FindViewById<Button>(Resource.Id.pick3Button);
			Button button2 = FindViewById<Button>(Resource.Id.pick4Button);
			Button button3 = FindViewById<Button>(Resource.Id.cash5Button);
			Button button4 = FindViewById<Button>(Resource.Id.Luck4LifeButton);
			Button button5 = FindViewById<Button>(Resource.Id.megamillsButton);
			Button button6 = FindViewById<Button>(Resource.Id.powerballButton);

			button1.Click += delegate { button1.Text = $"{count++} clicks!"; };
			button2.Click += delegate { button2.Text = $"{count++} clicks!"; };
			button3.Click += delegate { button3.Text = $"{count++} clicks!"; };
			button4.Click += delegate { button4.Text = $"{count++} clicks!"; };
			button5.Click += delegate { button5.Text = $"{count++} clicks!"; };
			button6.Click += delegate { button6.Text = $"{count++} clicks!"; };
		}
	}
}

