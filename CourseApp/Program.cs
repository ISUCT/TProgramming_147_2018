using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Program
    {
        public static double y(double x, double a, double b)
        {
            return (Math.Pow(Math.Log10(x / a), 2) + 1) / (b - Math.Exp(x / a));
        }

        static void Main(string[] args)
        {
            double a = 2.0;
            double b = 0.95;
            double xn = 1.25;
            double xk = 2.75;
            double dx = 0.3;

            double[] x = new double[5] { 2.2,
                                        3.78,
                                        4.51,
                                        6.58,
                                        1.2 };

            Console.WriteLine("Задача A:");
            do
            {
                Console.WriteLine($"Для x = {xn}\t y = {y(xn, a, b)}");
                xn += dx;
            } while (xn < xk);

            Console.WriteLine("Задача B:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Для x = {x[i]}\t y = {y(x[i], a, b)}");
            }
          
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
