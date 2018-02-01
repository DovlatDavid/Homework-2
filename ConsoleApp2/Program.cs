using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DUD's bread");
            double hac1 = double.Parse(Console.ReadLine());
            Console.WriteLine("DUD's milk");
            double milk1 = double.Parse(Console.ReadLine());
            Console.WriteLine("DUD's coffee");
            double cof1 = double.Parse(Console.ReadLine());
            Console.WriteLine("DUD's matsun");
            double mats1 = double.Parse(Console.ReadLine());
            Console.WriteLine("DUD's cheese");
            double ch1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Aparan's bread");
            double hac2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Aparan's milk");
            double milk2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Aparan's coffee");
            double cof2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Aparan's matsun");
            double mats2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Aparan's cheese");
            double ch2 = double.Parse(Console.ReadLine());
            double x = hac1 + milk1 + cof1 + mats1 + ch1;
            double y = hac2 + milk2 + cof2 + mats2 + ch2;
            string a = x > y ? "Aparan" : "DUD";
            string info = $"Better do your shopping here: {a}";
            Console.WriteLine(info);

        }
    }
}
