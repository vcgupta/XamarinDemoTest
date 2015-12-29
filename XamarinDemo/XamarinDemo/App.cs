using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemo
{
    public class App : Application
    {
        public static string MESSAGE_OPEN_NATIVE_PAGE = "OpenNativePage";
        public App()
        {
            var btnLogin = new Button { Text = "OpenLogin Model" };
            btnLogin.Clicked += async (s, e) => await OpenModelPopup();

            var btnNative= new Button { Text = "Open Native Activity" };
            btnNative.Clicked += (s, e) =>
            {
                MessagingCenter.Send(this, MESSAGE_OPEN_NATIVE_PAGE);
                
            };
            
            // The root page of your application
            MainPage = new ContentPage
            {
               
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        },
                        btnLogin, btnNative
                    }
                }
            };
        }

         

        public async Task OpenModelPopup()
        {
            await this.MainPage.Navigation.PushModalAsync(new LoginPopUp());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
