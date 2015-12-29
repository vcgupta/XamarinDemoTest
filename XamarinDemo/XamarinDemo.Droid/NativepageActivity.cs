using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;

namespace XamarinDemo.Droid
{
    [Activity(Label = "NativepageActivity")]
    public class NativepageActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.NativeDroidPage);

            Button buttonLogin = FindViewById<Button>(Resource.Id.btnLogin);
            buttonLogin.Click += ButtonLogin_Click;
            //To ignore SSL Certificate, need to implement Native WebView and then based on logic of redirection of pages in webView need to open LoginPopup.
            WebView webView = FindViewById<WebView>(Resource.Id.webView1); 
            //webView.LoadUrl("http://www.xamarin.com/");
            // Create your application here
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
           await XamarinDemo.App.Current.MainPage.Navigation.PushModalAsync(new LoginPopUp()));
           
        }
    }
}