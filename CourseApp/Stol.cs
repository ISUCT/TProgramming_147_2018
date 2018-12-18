﻿using System;

namespace ConsoleApp2
{
    using System;

    public class Stol : Furniture
    {
        private string name;
        private int length;
        private int height;

       public Stol(string produced, string name, int length, int height)
        : base(produced)
        {
            this.name = name;
            this.length = length;
            this.height = height;
        }

        public Stol(string produced, int length, int height)
            : base(produced)
        {
            name = "Noname";
            this.length = length;
            this.height = height;
        }

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

        public string GetInfo()
        {
            return $"Произведенно в : {Produced} Имя: {name}  Длина: {length}  Высота: {height}";
        }
    }
}