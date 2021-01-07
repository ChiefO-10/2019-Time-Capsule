using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguesser
{
    public class Class2
    {
        public void numbergame()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Chief";

            //  Program header (blue)
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();


            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("{0}? Let's play a game... {0}", name);

            Random rng = new Random();

            int rightNumber = rng.Next(1, 9);
            Console.WriteLine("What's your number {0}? Choose wisely", name);
            string userNumberString = Console.ReadLine();
            int userNumberInt;
            int.TryParse(userNumberString, out userNumberInt);
            if (rightNumber == userNumberInt) Console.WriteLine("Hmmm you are correct ... interesting. Isn't it {0}", name);
            else Console.WriteLine("Ha Ha HA you are wrong! It's {0}", rightNumber);
            Console.ReadKey();
        }
    }
}
