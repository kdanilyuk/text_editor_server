using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using textedb.Models;

namespace textedb.Services
{
    public class RegisterService
    {
        
        public async Task<User> Register(string login, string password)
        {
            var dbs = new DataBaseService();

            var isSuccessful = true;

            if (!dbs.IsOnBase(login))
            {
                File.AppendAllText(@"D:\Study\МТ\Course\textedb\database.txt", login + ":" + password + ":" + "user" + ":" + "true" + "\r\n");
            }
            else
            {
                isSuccessful = false;
            }

            return new User(login, password, "user", isSuccessful);
        }
    }
}
