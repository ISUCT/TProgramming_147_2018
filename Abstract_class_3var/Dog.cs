using System;

namespace ConsoleApp1
{
    using System;

    public class Dog : Animal
    {
        public Dog()
        {
            Name = "Rex";
            Breed = "German Shepherd";
            Age = 1;
        }

        public Dog(string breed, string name, int age)
        : base(breed, name)
        {
            Name = name;
            Age = age;
        }

        public Dog(string breed, int age)
        : base(breed)
        {
            Age = age;
        }

        public Dog(int age)
        : base()
        {
            Age = age;
        }

        public override string GetInfo()
        {
            return $"Порода: {Breed} Имя: {Name}  Возраст: {Age}";
        }
    }
}