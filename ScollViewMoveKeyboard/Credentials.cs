using System;
namespace ScollViewMoveKeyboard
{
    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Credentials(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}
