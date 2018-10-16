using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp20
{
    class Program
    {
        static void Main()
        {
            double a = 0.8;
            double b = 0.4;
            double y;
            for (double x = 1.23; x <= 7.23; x = x + 1.2)
            {
                y = ((Math.Pow((Math.Pow((x - a), 2)), 1/3.0)) + ((Math.Pow((Math.Abs(x + b)),1 / 5))) / ((Math.Pow(Math.Pow(x,2) - Math.Pow((a+b),2), 1/5.0))));
                Console.WriteLine($"На шане {x} функция y= {Math.Round(y,4)}");
            }
            Console.ReadKey();
        }
        
    }
}
