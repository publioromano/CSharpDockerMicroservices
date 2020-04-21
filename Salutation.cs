using System;

namespace Learning
{
    public class Salutation
    {
        public string Salut(string nome){
            DateTime now = DateTime.Now;

            if (now.Hour < 12) return "Good morning, " + nome + "!";
            else if (now.Hour < 18) return "Good afternoom, " + nome + "!";
            else return "Good evening, " + nome + "!";
        }
    }
}
