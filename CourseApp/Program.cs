using System;

namespace Matan
{
    class Program
    {
        public static double y(double x, double a, double b)
        {
            return (Math.Asin(Math.Pow(x, a) + Math.Acos(Math.Pow(x, b))));
        }

        static void Main(string[] args)
        {
            double a = 2;
            double b = 3;
            double xn = 0.11;
            double xk = 0.36;
            double dx = 0.05;

            double[] x = new double[5] { 0.08, 0.26, 0.35, 0.41, 0.53 };

            Console.WriteLine("Задача A:");
            
            for (double xl = xn; xl < xk; xl += dx)
            {
                Console.WriteLine($"Для x = {xl}\t y = {y(xl, a, b)}");
            }

            Console.WriteLine("Задача B:");
             
            foreach (double i in x)
            {
                Console.WriteLine($"Для x = {i}\t y = {y(i, a, b)}");
            }
        }
    }
}