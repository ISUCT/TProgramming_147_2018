using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шишлаб2
{
    class Program
    {
        static public void calculate(double x, double a)
        {
            double y;
            y = (Math.Log(a + x)) * (Math.Log(a + x)) / (a + x) * (a + x);
            Console.WriteLine($"y = {y}");

        }

        static void Main(string[] args)
        {
            double a = 2;
            double x1 = 1.16, x2 = 1.32, x3 = 1.47, x4 = 1.65, x5 = 1.93;
            calculate(x1, a);
            calculate(x2, a);
            calculate(x3, a);
            calculate(x4, a);
            calculate(x5, a);
            Console.ReadKey(true);
        }
    }
}