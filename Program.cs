using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter principal: ");
            int principal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter rate: ");
            int rate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter time (years): ");
            int time = Convert.ToInt32(Console.ReadLine());

            int simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine("Simple Interest: " +  simpleInterest);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
