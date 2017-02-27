using Ddmurthare.Service.Concrete;
using Ddmurthare.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddmurthare.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputeLogic computeLogic = new ComputeLogic();

            Console.WriteLine("Please enter element...");
            string element = Console.ReadLine();
            Console.WriteLine("Please enter symbol...");
            string symbol = Console.ReadLine();
            if (computeLogic.ComputeElement(element, symbol))
            {
                Console.WriteLine( element+", "+symbol+" -> true");
            }
            else
            {
                Console.WriteLine(element + ", " + symbol + " -> false");

            }
            Console.ReadLine();
        }
    }
}
