using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ScollViewMoveKeyboard
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
            Console.WriteLine(ObjectDumper.Dump(Singleton.Shared.CurrentUserCredentials));


            if (Application.Current.Properties.ContainsKey("CurrentTheme"))
            {
                Themes currentTheme = (Themes)Application.Current.Properties["CurrentTheme"];
                Console.WriteLine(currentTheme);
            }

        }

    }
}
