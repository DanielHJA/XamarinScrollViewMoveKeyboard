using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ScollViewMoveKeyboard
{
    public class MainViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

        public MainViewModel()
        {
        }

        public async Task<bool> Authorize()
        {
            Credentials credentials = new Credentials(Username, Password);
            return await Authorize(credentials);
        }

        private async Task<bool> Authorize(Credentials credentials)
        {
            System.Console.WriteLine(credentials);
            await Task.Delay(3000);
            Singleton.Shared.CurrentUserCredentials = credentials;
            return true;
        }

    }
}
