using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            int userChoice;
            string userChoiceString;
            int min = 1;
            int max = 4;
           
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            WriteLine("1- Rock\n2- Paper\n3- Scissors");
            userChoiceString = ReadLine();
            userChoice = Convert.ToInt32(userChoiceString);

            if(userChoice == 1 && randomNumber == 1)
            {
                WriteLine("Tie");
            }
            else if (userChoice == 2 && randomNumber == 2)
            {
                WriteLine("Tie");
            }
            else if (userChoice == 3 && randomNumber == 3)
            {
                WriteLine("Tie");
            }
            else if (userChoice == 1 && randomNumber == 2)
            {
                WriteLine("You Lose");
            }
            else if (userChoice == 2 && randomNumber == 3)
            {
                WriteLine("You Lose");
            }
            else if (userChoice == 3 && randomNumber == 1)
            {
                WriteLine("You Lose");
            }
            else if (userChoice == 1 && randomNumber == 3)
            {
                WriteLine("You Win");
            }
            else if (userChoice == 3 && randomNumber == 2)
            {
                WriteLine("You Win");
            }
            else if (userChoice == 2 && randomNumber == 1)
            {
                WriteLine("You Win");
            }

        }
    }
}
