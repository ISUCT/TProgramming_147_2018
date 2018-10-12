using System;

namespace Matan
{
    class Program
    {
        public static double y(double x, double a, double b)
        {
            return (Math.Acos(Math.Pow(x, 2) - Math.Pow(b, 2)) / Math.Asin(Math.Pow(x, 2) - Math.Pow(a, 2)));
        }

        static void Main(string[] args)
        {
            double a = 0.05;
            double b = 0.06;
            double xn = 0.2;
            double xk = 0.95;
            double dx = 0.15;

            double[] x = new double[5] { 0.15, 0.26, 0.37, 0.48, 0.56 };

            Console.WriteLine("Задача A:");
            //do
            //{
            //    Console.WriteLine($"Для x = {xn}\t y = {y(xn, a, b)}");
            //    xn += dx;
            //} while (xn < xk);
            for (double xl = xn; xl < xk; xl+=dx)
            {
                Console.WriteLine($"Для x = {xl}\t y = {y(xl, a, b)}");
            }

            Console.WriteLine("Задача B:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Для x = {x[i]}\t y = {y(x[i], a, b)}");
            //}
            foreach (double i in x)
            {
                Console.WriteLine($"Для x = {i}\t y = {y(i, a, b)}");
            }
        }
    }
}