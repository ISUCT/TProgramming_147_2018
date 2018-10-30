using System;

namespace Matemat

{
    public class Program
    {
        public static double y(double x, double a, double b)
        {
            return (Math.Pow(a * x + b, 1 / 3) / (Math.Log10(x) * Math.Log10(x)));
        }

        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Console.WriteLine("Hello World!");
=======
            double a = 1.35;
            double b = 0.98;
            double xn = 1.14;
            double xk = 4.24;
            double dx = 0.62;

            double[] x = new double[5] { 0.35, 1.26, 0.37, 0.48, 0.56 };

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
>>>>>>> Stashed changes
        }
    }
}