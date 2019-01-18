using System;

namespace ConsoleApp1
{
    using System;

    public abstract class Animal
    {
        private string breed;
        private string name;
        private int age;
        private string color;

        public Animal()
        {
        }

        public Animal(string breed, string name)
        {
            Name = name;
            Breed = breed;
        }

        public Animal(string breed)
        {
            Name = "Noname";
            Breed = breed;
        }

        public int Age
        {
            get => age;
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        public string Color { get => color; set => color = value; }

        public string Name { get => name; set => name = value; }

        public string Breed { get => breed; set => breed = value; }

        public override string ToString()
        {
            return GetInfo();
        }

        public abstract string GetInfo();
    }

}