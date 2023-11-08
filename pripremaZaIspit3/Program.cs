using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaIspit3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, d = 0, x = 0;

            Console.WriteLine("Upišite vrijednosti a, b, c i d");

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            x = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)) / (Math.Pow(a + b, 2) + Math.Pow(c + d, 2));

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
