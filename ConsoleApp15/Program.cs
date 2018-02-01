using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=LENGHT=-");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("-=WIDTH=-");
            double b = double.Parse(Console.ReadLine());
            double s = a * b;
            double p = 2 * (a + b);
            Console.WriteLine("-=AREA=-");
            Console.WriteLine(s);
            Console.WriteLine("-=PERIMETER=-");
            Console.WriteLine(p);
        
        }
    }
}
