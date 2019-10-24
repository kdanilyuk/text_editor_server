using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using textedb.Models;

namespace textedb.Services
{
    public class LoginService
    {
        public async Task<User> Login(string login, string password)
        {
            User user;

            var dbs = new DataBaseService();

            if (dbs.Login(login, password))
                user = new User(login, password, dbs.GetRoots(login), dbs.GetValidity(login));
            else
                user = new User("invalid", "invalid", "invalid", false);

            return user;
        }
    }
}
