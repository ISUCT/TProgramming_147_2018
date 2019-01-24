using System;

namespace ConsoleApp2
{
    using System;

    public abstract class Furniture
    {
        private string produced;
        private string name;
        private int length;
        private int height;
        private string material;

        public Furniture()
        {
        }

        public Furniture(string produce, string name)
        {
            Name = name;
            Produced = produce;
        }

        public Furniture(string produce)
        {
            Name = "Noname";
            Produced = produce;
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

        public string Material { get => material; set => material = value; }

        public string Name { get => name; set => name = value; }

        public string Produced { get => produced; set => produced = value; }

        public override string ToString()
        {
            return GetInfo();
        }

        public abstract string GetInfo();
    }
}