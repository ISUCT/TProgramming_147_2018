using System;
using CourseApp;

namespace laba2
{
    public class Program
    {
        public static double Formula(double x, double a, double b)
        {
            return ((Math.Pow(a, x) - Math.Pow(b, x)) / Math.Log10(a / b)) * Math.Pow(a * b, 1 / 3);
        }

        private static void Main()
        {
            Console.WriteLine("Первая часть");
            double a = 0.4;
            double b = 0.8;

            for (double x = 3.2; x <= 6.2; x += 0.6)
            {
                Console.WriteLine($"При x = {x} y = {Formula(x, a, b)}");
            }

            Console.WriteLine();
            Console.WriteLine("Вторая часть");
            double[] z = new double[5] { 4.48, 3.56, 2.78, 5.28, 3.21 };
            for (int i = 0; i <= z.Length - 1; i++)
            {
                Console.WriteLine($"При x = {z[i]} y = {Formula(z[i], a, b)}");
            }

            Appliances[] appliances = new Appliances[2];
            appliances[0] = new Television(151, 49620, 7);
            appliances[1] = new Microwave(800, 414, 4);
            foreach(Appliances i in appliances)
            {
               i.GetInfo();
            }

            Console.ReadKey();
        }

    }
}
