using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Animal[] animals = new Animal[2];

            animals[0] = new Cat();
            animals[1] = new Dog();

            foreach(Animal animal in animals)
            Console.WriteLine(animal.GetInfo());
        }
    }
}