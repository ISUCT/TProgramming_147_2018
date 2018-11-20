using System;

namespace ConsoleApp2
{
    using System;

    public class Stol
    {
        private string name;
        private int length;
        private int height;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Height
        {
            get => height;
            set
            {
                if (value > 0)
                {
                    height = value;
                }
            }
        }
        public int Lenght
        {
            get => length;
            set
            {
                if (value > 0)
                {
                    length = value;
                }
            }
        }
        public Stol(string name, int length, int height)
        {
            this.name = name;
            this.length = length;
            this.height = height;
        }
        public Stol(int length, int height)
        {
            this.name = "Noname" ;
            this.length = length;
            this.height = height;
        }
        public string GetInfo()
        {
            return $"Имя: {name}  Длина: {length}  Высота: {height}";
        }
    }
}