using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScollViewMoveKeyboard
{

    public enum Themes
    {
        dark,
        light
    }

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            Application.Current.Properties["CurrentTheme"] = Themes.light;


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
