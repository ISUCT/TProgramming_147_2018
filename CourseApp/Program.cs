using System;
using Samolet;

namespace ConsoleApp3
{
    public class Program
    {
        public static double Y(double x, double a, double b)
        {
            return Math.Log10((x * x) - 1) / Math.Log((a * x * x) - b, 5);
        }

        public static void Main()
        {
            double a = 1.1;
            double b = 0.09;

            double[] x1 = new double[5] { 1.21, 1.76, 2.53, 3.48, 4.52 };

            Console.WriteLine("Задача A:");

            for (double x = 1.2; x <= 2.2; x = x + 0.2)
            {
                Console.WriteLine($"На шаге {x} функция y = {Math.Round(Y(x, a, b), 4)}");
            }

            Console.WriteLine("Задача B:");

            foreach (double i in x1)
            {
                Console.WriteLine($"Для x = {i}\t y = {Y(i, a, b)}");
            }

            Airplane airplane1 = new Airplane(700, "samoletik");
            Console.WriteLine(airplane1.GetInfo());

            Airplane airplane2 = new Airplane(700);

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
