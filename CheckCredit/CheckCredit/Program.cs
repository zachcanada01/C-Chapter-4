using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            string priceString;
            double creditLimit = 5000;

            WriteLine("What is the price of your item?");
            priceString = ReadLine();
            price = Convert.ToInt32(priceString);

            if(price > creditLimit)
            {
                WriteLine("Error");
            }
            else if(price < creditLimit)
            {
                WriteLine("Approved");
            }
        }
    }
}
