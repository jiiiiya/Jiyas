﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace OpenWebpage
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += (sender, e) => {

                var uri = Android.Net.Uri.Parse("http://developer.xamarin.com");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);

            };
        }
    }
}