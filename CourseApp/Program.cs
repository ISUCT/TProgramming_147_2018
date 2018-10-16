using System;

namespace CourseApp
{
    class Program
    {
                
                
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Первая часть");
            double a = 0.4;
            double b = 0.8;

            for (double x = 3.2; x <= 6.2; x = x + 0.6)
            {
                double y = ((Math.Pow(a, x) - Math.Pow(b, x)) / (Math.Log10(a / b))) * Math.Pow(Math.Sqrt(a * b), 1 / 3);
                Console.WriteLine($"При х = {x} функция y = {Math.Round(y, 4)}");
            }

            Console.WriteLine();
            Console.WriteLine("Вторая часть");
            
            double[] z = new double[5] { 4.48, 3.56, 2.78, 5.28, 3.21 };
            for (int i = 0; i <= 4; i++)
            {
                double y = ((Math.Pow(a, z[i]) - Math.Pow(b, z[i])) / (Math.Log10(a / b))) * Math.Pow(Math.Sqrt(a * b), 1 / 3);
                Console.WriteLine($"При х = {z[i]} функция y = {Math.Round(y, 4)}");
            }


            Console.ReadKey();
        }

    }
}
