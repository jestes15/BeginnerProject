using System.Threading.Tasks;

namespace BeginnersProject
{
    public struct LoginDetails
    {
        private string _password;
        private string _encodedPassword;
        private string _username;
        private string _encodedUsername;

        public Task set_password(string x)
        {
            _password = x;
            return Task.CompletedTask;
        }

        public string get_password()
        {
            return _password;
        }

        public Task set_encoded_password(string x)
        {
            _encodedPassword = x;
            return Task.CompletedTask;
        }

        public string get_encoded_password()
        {
            return _encodedPassword;
        }
        
        public Task set_username(string x)
        {
            _username = x;
            return Task.CompletedTask;
        }

        public string get_username()
        {
            return _username;
        }

        public Task set_encoded_username(string x)
        {
            _encodedUsername = x;
            return Task.CompletedTask;
        }

        public string get_encoded_username()
        {
            return _encodedUsername;
        }
    }
}