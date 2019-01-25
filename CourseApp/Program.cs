using System;

namespace CourseApp
{
    public class Program
    {
        public static double Y(double x, double a, double b)
        {
            return (Math.Pow(Math.Pow(x - a, 2), 1 / 3.0) + Math.Pow(Math.Abs(x + b), 1 / 5)) / Math.Pow(Math.Pow(x, 2) - Math.Pow(a + b, 2), 1 / 5.0);
        }

        public static void Main(string[] args)
        {
            double a = 0.8;
            double b = 0.4;
            double xn = 1.23;
            double xk = 7.23;
            double dx = 1.2;

            double[] x = new double[5] { 1.88, 2.26, 3.84, 4.55, -6.21 };

            Console.WriteLine("Задача A:");

            for (double xl = xn; xl < xk; xl += dx)
            {
                Console.WriteLine($"Для x = {xl}\t y = {Y(xl, a, b)}");
            }

            Console.WriteLine("Задача B:");

            foreach (double i in x)
            {
                Console.WriteLine($"Для x = {i}\t y = {Y(i, a, b)}");
            }
        }
    }
}