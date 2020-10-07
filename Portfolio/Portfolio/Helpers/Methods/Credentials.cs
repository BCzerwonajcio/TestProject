using Newtonsoft.Json;
using System;
using System.IO;

namespace Portfolio.Helpers.Methods
{
    public static class Credentials
    {
        public static string Login { get; private set; }
        public static string Password { get; private set; }

        public static void CredentialConfiguration()
        {
            using (var r = new StreamReader
                (Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Helpers\\Doc\\Credentials.json")))
            {
                var json = JsonConvert.DeserializeObject<JsonCredentials>(r.ReadToEnd());
                Login = json.Login;
                Password = json.Password;
            }
        }

        public class JsonCredentials
        {
            public string Password { get; set; }
            public string Login { get; set; }
        }
    }
}
