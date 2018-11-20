using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            string userString;
            
            Console.Write("Pick a number 1-3 >>");
            userString = ReadLine();
            userChoice = Convert.ToInt32(userString);

            if (userChoice == 2)
            {
                Console.WriteLine("You Win");
            }
            else if (userChoice == 1 | userChoice == 3)
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
