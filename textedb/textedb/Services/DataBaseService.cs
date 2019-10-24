using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace textedb.Services
{
    public class DataBaseService
    {
        Dictionary<string, string[]> database = new Dictionary<string, string[]>();

        public DataBaseService()
        {
            OnInit();
        }

        void OnInit()
        {
            foreach (var line in File.ReadAllLines(@"D:\Study\МТ\Course\textedb\database.txt"))
            {
                var clearLine = Regex.Replace(line, @",\r\n", "");
                var logpass = clearLine.Split(new char[] { ':' });

                database.Add(logpass[0], new string[] { logpass[1], logpass[2], logpass[3] });
                //  KEY: Logpass[0] - login
                //VALUE: logpass[1] - password
                //       logpass[2] - roots
                //       logpass[3] - isValid
            }
        }

        public bool Login(string login, string password) => (database.ContainsKey(login) && database[login][0] == password);

        public bool IsOnBase(string login) => database.ContainsKey(login);

        public string GetPassword(string login) => database[login][0];

        public string GetRoots(string login) => database[login][1];

        public bool GetValidity(string login) => Boolean.Parse(database[login][2]);
    }
}
