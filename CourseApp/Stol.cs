using System;

namespace ConsoleApp2
{
    using System;

    public class Stol : Furniture
    {
        public Stol()
        {
            Name = "chto-to";
            Produced = "Russia";
        }

        public Stol(string produced, string name, int length, int height)
        : base(produced, name)
        {
            Name = name;
            Lenght = length;
            Height = height;
        }

        public Stol(string produced, int length, int height)
            : base(produced)
        {
            Lenght = length;
            Height = height;
        }

        public Stol(int length, int height)
           : base()
        {
            Lenght = 200;
            Height = 100;
        }

        public override string GetInfo()
        {
            return $"Произведенно в : {Produced} Имя: {Name}  Длина: {Lenght}  Высота: {Height}";
        }
    }
}