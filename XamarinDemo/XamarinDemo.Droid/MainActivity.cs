using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;

namespace XamarinDemo.Droid
{
    [Activity(Label = "XamarinDemo", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            Xamarin.Forms.MessagingCenter.Subscribe<XamarinDemo.App>(this, App.MESSAGE_OPEN_NATIVE_PAGE, OpenModelPopup);
        }
        private void OpenModelPopup(XamarinDemo.App sender)
        {
            StartActivity(typeof(NativepageActivity));
          
        }
    }
}

