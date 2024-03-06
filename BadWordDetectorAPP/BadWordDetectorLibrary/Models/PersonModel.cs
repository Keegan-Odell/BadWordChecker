using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadWordDetectorLibrary.Models
{
    public class PersonModel
    {
        public event EventHandler<string> BadWord; 

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public PersonModel(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public string BadWordChecker(string wordToCheck)
        {
            string wordToSend = wordToCheck;
            if (wordToCheck.ToLower() == "shit" || wordToCheck.ToLower() == "fuck")
            {
                BadWord?.Invoke(this, "Bad Word detected");
                wordToSend = "****";
            }
            return wordToSend;
        }
    }
}
