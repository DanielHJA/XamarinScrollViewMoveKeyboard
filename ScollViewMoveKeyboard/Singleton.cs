using System;
namespace ScollViewMoveKeyboard
{
    public class Singleton
    {

        private static readonly Singleton Instance = new Singleton();
        public static Singleton Shared
        {
            get
            {
                return Instance;
            }
        }

        private Singleton() { }

        public Credentials CurrentUserCredentials;

    }

}
