using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textedb.Models
{
    [Serializable]
    public class User
    {
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "roots")]
        public string Roots { get; set; }

        [JsonProperty(PropertyName = "is_valid")]
        public bool IsValid { get; set; }

        public User()
        {

        }

        public User(string login, string password, string roots, bool isValid)
        {
            Login = login;
            Password = password;
            Roots = roots;
            IsValid = isValid;
        }

        public override string ToString()
        {
            return Login.ToString() + ":" + Password.ToString() + ":" + Roots.ToString() + ":" + IsValid.ToString();
        }
    }
}
