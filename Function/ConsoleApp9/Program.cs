using System;

namespace Matan
{
    class Program
    {
        public static double y(double x, double a, double b)
        {
            return Math.Pow((Math.Pow(Math.Asin(x), 2) + Math.Pow(Math.Acos(x), 4)),3);
        }

        static void Main(string[] args)
        {
           
            double a = 0;
            double b = 0;
            double xn = 0.26;
            double xk = 0.66;
            double dx = 0.08;

            double[] x = new double[5] { 0.1, 0.35, 0.4, 0.55, 0.6 };

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