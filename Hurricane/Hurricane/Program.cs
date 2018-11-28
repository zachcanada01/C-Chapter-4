using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            double windSpeed;
            string windSpeedString;

            WriteLine("What are the wind speeds?");
            windSpeedString = ReadLine();
            windSpeed = Convert.ToDouble(windSpeedString);

            if(windSpeed >= 157)
            {
                WriteLine("Category 5 hurricane");
            }
            else if (windSpeed >= 130)
            {
                WriteLine("Category 4 hurricane");
            }
            else if (windSpeed >= 111 && windSpeed < 130)
            {
                WriteLine("Category 3 hurricane");
            }
            else if (windSpeed >= 96 && windSpeed < 111)
            {
                WriteLine("Category 2 hurricane");
            }
            else if (windSpeed>= 74 && windSpeed < 96)
            {
                WriteLine("Category 1 hurricane");
            }
            else if (windSpeed < 74)
            {
                WriteLine("There is no hurricane");
            }
        }
    }
}
