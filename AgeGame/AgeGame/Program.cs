using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AgeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int usersAge;
            string ageString;
            string yesString;
            int yes;
           

            Write("Please enter your age to be insulted");
            ageString = ReadLine();
            usersAge = Convert.ToInt32(ageString);

            if (usersAge <= 12)
            {
                Write("You are a child! Go away!");
            }
            else if (usersAge >= 13 && usersAge <= 18)
            {
                Write("You are a teen");
            }
            else if (usersAge >= 19 && usersAge <= 25)
            {
                Write("Do you have a job? 1 for yes or 2 for no.");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if (yes == 1)
                    Write("Good for you.");
                else
                    Write("Get a job hippie");
            }
            else if (usersAge >= 26 && usersAge <= 30)
            {
                Write("Hopefully you are out of your parents house");
            }
            else if (usersAge >= 31 && usersAge <= 40)
            {
                Write("I don't know");
            }
            else if (usersAge >= 41 && usersAge <= 50)
            {
                Write("You are getting old");
            }
            else if (usersAge >= 51 && usersAge <= 60)
            {
                Write("You are getting very old now");
            }
            else if (usersAge >= 61 && usersAge <= 120)
            {
                Write("Still alive?");
            }

            
            //0-12
            //13-18
            //19-25
            //26-30
            //31-40
            //41-50
            //51-60
            //61-120
        }
    }
}
