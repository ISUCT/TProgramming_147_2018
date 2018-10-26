using System;

namespace Matan
{
    public class Program
    {
        public static double y1(double x)
        {
            if (Math.Abs(x) >= 1)
            {
                return (Math.Pow(1.2, x) - Math.Pow(x, 1.2));
            }
            else
            {
                return (Math.Acos(x));
            }
        }
        
        static void Main(string[] args)
        {
            double xn = 0.2;
            double xk = 2.2;
            double dx = 0.4;

            double[] x = new double[5] { 0.1, 0.9, 1.2, 1.5, 2.3 };
            
                    Console.WriteLine("Задача A:");

                    for (double xl = xn; xl < xk; xl += dx)
                    {
                        Console.WriteLine($"Для x = {xl}\t y = {y1(xl)}");
                    }

                    Console.WriteLine("Задача B:");
                    
                    foreach (double i in x)
                    {
                        Console.WriteLine($"Для x = {i}\t y = {y1(i)}");
                    }
               
            
                
            
                
        }
    }
}