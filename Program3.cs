using System;

namespace Matan
{
    class Program
    {
        public static double y(double x, double a)
        {
            return ((Math.Log(a + x)) * (Math.Log(a + x)) / (a + x) * (a + x)); 
        }

        static void Main(string[] args)
        {
            double a = 2.0;
            double xn = 1.2;
            double xk = 4.2;
            double dx = 0.6;

            double[] x = new double[5] { 1.16,1.32, 1.47, 1.65, 1.93 };

            Console.WriteLine("Задача A:");
            //do 
            //{ 
            // Console.WriteLine($"Для x = {xn}\t y = {y(xn, a)}"); 
            // xn += dx; 
            //} while (xn < xk); 
            for (double xl = xn; xl < xk; xl += dx)
            {
                Console.WriteLine($"Для x = {xl}\t y = {y(xl, a)}");
            }

            Console.WriteLine("Задача B:");
            //for (int i = 0; i < 5; i++) 
            //{ 
            // Console.WriteLine($"Для x = {x[i]}\t y = {y(x[i], a)}"); 
            //} 
            foreach (double i in x)
            {
                Console.WriteLine($"Для x = {i}\t y = {y(i, a)}");
            }
        }
    }
}