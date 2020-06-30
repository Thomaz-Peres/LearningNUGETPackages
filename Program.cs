using System;
using Newtonsoft.Json;

namespace LearnNUget
{
    public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account
            {
                Name = "Thomaz Peres",
                Email = "thomaz@nuget.org",
                DOB = new DateTime (1999, 8, 5, 0, 0, 0, DateTimeKind.Utc),
            };
            
            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
