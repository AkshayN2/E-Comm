namespace ECommerce_Application
{
    class Auth
    {
        private bool _isAuth = false;

        public void logIn()
        {
            this._isAuth = true;
        }

        public void logOut()
        {
            this._isAuth = false;
        }

    }
}
