using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            int maxText = 140;




            WriteLine("Enter Message Here>");
            message = ReadLine();

            if(message.Length> maxText)
            {
                WriteLine("To many characters, max is 140");
            }
            else if(message.Length< maxText)
            {
                WriteLine("Approved");
            }
        }
    }
}
