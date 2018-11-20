using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp1;
            int temp2;
            int temp3;
            double conversion1;
            double conversion2;
            double conversion3;
            string inputString1;
            string inputString2;
            string inputString3;
            


            Write("What will the temperature be at 8:00 am?");
            inputString1 = ReadLine();
            temp1 = Convert.ToInt32(inputString1);
            Write("What will the temperature be at 12:00 pm?");
            inputString2 = ReadLine();
            temp2 = Convert.ToInt32(inputString2);
            Write("What will the temperature be at 5:00 pm?");
            inputString3 = ReadLine();
            temp3 = Convert.ToInt32(inputString3);

            conversion1 = (temp1 - 32) * 5 / 9;
            conversion2 = (temp2 - 32) * 5 / 9;
            conversion3 = (temp3 - 32) * 5 / 9;

            

            WriteLine("Fahrenheit for 8:00 am = " + temp1 + ". Celsius for 8:00 am = " + conversion1);
            WriteLine("Fahrenheit for 12:00 pm = " + temp2 + ". Celsius for 12:00 pm = " + conversion2);
            WriteLine("Fahrenheit for 5:00 pm = " + temp3 + ". Celsius for 5:00 pm = " + conversion3);

            if (temp1 < 32 | temp1 < 32 | temp3 < 32)
            {
                WriteLine("Today will be freezing.");
            }
            else if (temp1 > 100 | temp2 > 100 | temp3 > 100)
            {
                WriteLine("Today will be hot.");
            }
        }
    }
}
