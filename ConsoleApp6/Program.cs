using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int x = a / 100;
            int y = (a - (100 * x)) / 10;
            int z = a - (100 * x) - (10 * y);

            Console.WriteLine($"First Number: {x}, Second Number: {y}   Third Number: {z}");
            
            
            

            
        }
    }
}
