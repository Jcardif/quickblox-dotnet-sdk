﻿using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Android.Content.PM;
using Xamarin.Forms;
using Acr.UserDialogs;
using QbChat.Pcl.Repository;
using QbChat.Pcl;

namespace XamarinForms.QbChat.Android
{
	[Activity (Theme = "@android:style/Theme.Holo.Light", Label = "", Icon="@android:color/transparent")]
	public class FormsActivity : FormsApplicationActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			this.RequestedOrientation = ScreenOrientation.Portrait;

			Forms.Init (this, savedInstanceState);
			Database.Instance ().Init (DependencyService.Get<ISqlite> ().GetConnection ());
			UserDialogs.Init (this);

            Quickblox.Sdk.Platform.QuickbloxPlatform.Init();
            var app = new App ();
			LoadApplication (app);
		}
	}
}


