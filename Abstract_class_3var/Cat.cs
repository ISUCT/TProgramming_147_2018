using System;

namespace ConsoleApp1
{
    using System;

    public class Cat : Animal
    {
        public Cat()
        {
            Breed = "Maine coon";
            Name = "Fufik";
            Color = "Red";
        }

        public Cat(string breed, string name, string color)
        : base(breed, name)
        {
            Color = color;
        }

        public Cat(string breed, string color)
        : base(breed)
        {
            Breed = breed;
            Color = color;
        }

        public override string GetInfo()
        {
            return $"Порода: {Breed} Имя: {Name} Цвет: {Color}";
        }
    }

}