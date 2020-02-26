using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScollViewMoveKeyboard
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async void Register_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Task.Delay(3000);
            close();
        }

        private async void close()
        {
            await Navigation.PopModalAsync();
        }

        void Close_ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            close();
        }
    }
}
