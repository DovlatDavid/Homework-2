using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = 0;
            int min = 0;

            int x = a >= b & a >= c ? max = a : min = a;
            int y = b >= a & b >= c ? max = b : min = b;
            int z = c >= a & c >= b ? max = c : min = c;
            Console.WriteLine($"{max}   {min}");

        }
    }
}
