using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = args[0].Split(',');
              
            string developerName = input [0];
            string companyName = input[1];
            string location = input[2];

            Console.WriteLine("Developer name is: " + developerName);
            Console.WriteLine("Company name is: " + companyName);
            Console.WriteLine("Location is: " + location);
        }
    }
}
