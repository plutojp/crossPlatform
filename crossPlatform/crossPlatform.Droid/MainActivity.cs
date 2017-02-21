using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace crossPlatform.Droid
{
	[Activity (Label = "crossPlatform.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			//base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			//SetContentView (Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button> (Resource.Id.myButton);
            var textV1 = FindViewById<TextView>(Resource.Id.textView1);
            var editText1 = FindViewById<EditText>(Resource.Id.editText1);
            var button1 = FindViewById<Button>(Resource.Id.button1);
            double d = 0;
			button1.Click += (sender,e)=> {
                //button1.Text = string.Format ("{0} clicks!", count++);
                if (Double.TryParse(editText1.Text,out d))
                {
                    textV1.Text = string.Format ("{0}円", Calc.GetTax(d));

                }
            };
		}
	}
}


