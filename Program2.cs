using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шишлаб2
{
    class Program2
    {

        static void Main(string[] args)
        {
            double num = 1;
            double x = 1.2, xFinish = 4.2, xStep = 0.6, a = 2, y;
            while (x < xFinish)
            {
                y = (Math.Log(a + x)) * (Math.Log(a + x)) / (a + x) * (a + x);
                x += xStep;
                Console.WriteLine($"y{num} = {y}");
                num++; //счётчик выполнения цикла 
            }
            Console.ReadKey(true);
        }
    }
}