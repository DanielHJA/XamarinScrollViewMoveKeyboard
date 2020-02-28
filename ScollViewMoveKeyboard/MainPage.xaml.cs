using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScollViewMoveKeyboard
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        MainViewModel viewModel = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        async void Login_Button_Clicked(System.Object sender, System.EventArgs e)
        {

            CustomActivityIndicatorPage.Display("Loggar in");
            
            bool authorized = await viewModel.Authorize();

            CustomActivityIndicatorPage.Pop();

            if (authorized)
            {
                NavigationPage page = new NavigationPage(new LandingPage());
                page.BarBackgroundColor = Color.Transparent;
                Application.Current.MainPage = page;
            }

        }

        async void Register_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            NavigationPage page = new NavigationPage(new RegisterPage());
            await Navigation.PushModalAsync(page);
        }

    }
}
