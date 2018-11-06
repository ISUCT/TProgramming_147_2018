using System;

namespace Matan
{
    public class Program
    {
        public static double y(double x)
        {
            return (Math.Pow(Math.Abs(x * x - 2.5), 4.0) + Math.Pow(Math.Log10(x * x), 3.0));
        }

        static void Main(string[] args)
        {
            double xn = 1.25;
            double xk = 3.25;
            double dx = 0.4;

            double[] x = new double[5] { 1.84, 2.71, 3.81, 4.56, 5.62 };

            Console.WriteLine("Задача A:");
            for (double xl = xn; xl < xk; xl += dx)
            {
                Console.WriteLine($"Для x = {xl}\t y = {y(xl)}");
            }

            Console.WriteLine("Задача B:");

            foreach (double i in x)
            {
                Console.WriteLine($"Для x = {i}\t y = {y(i)}");
            }
        }
    }
}
