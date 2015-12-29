using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinDemo
{
    public class LoginPopUp : ContentPage
    {
        public LoginPopUp()
        {
            System.Diagnostics.Debug.WriteLine("Login poup is opened");
            var button =  new Button { Text="Authenticate and Close" };
            button.Clicked += (s, e) => Navigation.PopModalAsync();
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Login PopUp page", FontSize = 20 },
                    new Label { Text = "This can popup from PCL or Native depending on Authentication  requirement. This will always open as model", FontSize = 15 },
                   button
                }
            };
        }
    }
}
