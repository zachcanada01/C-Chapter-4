using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa;
            string gpaString;
            double test;
            string testString;

            WriteLine("Please enter your highschool grade point average.");
            gpaString = ReadLine();
            gpa = Convert.ToDouble(gpaString);
            WriteLine("Please enter you admission test score.");
            testString = ReadLine();
            test = Convert.ToDouble(testString);

            if (gpa >= 3 && test >= 60)
            {
                WriteLine("Accepted");
            }
            else if (gpa >= 3 && test >= 80)
            {
                WriteLine("Accepted");
            }
            else
                WriteLine("Rejected");
        }
    }
}
