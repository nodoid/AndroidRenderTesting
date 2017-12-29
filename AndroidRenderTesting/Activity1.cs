using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using System.IO;

namespace AndroidRenderTesting
{
    [Activity(Label = "AndroidRenderTesting", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            WebView webview = FindViewById<WebView>(Resource.Id.webView1);
            webview.Settings.JavaScriptEnabled = true;

            StreamReader reader = new StreamReader(Assets.Open("RenderHTML.html"));
            webview.LoadDataWithBaseURL(null, reader.ReadToEnd(), "text/html", "UTF-8", null);

            reader.Close();
        }
    }
}

