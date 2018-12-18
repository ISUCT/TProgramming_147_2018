using System;

namespace ConsoleApp2
{
    using System;

    public class Shcaf : Furniture
    {
        private string name;
        private int length;
        private int height;
        private string material;

        public Shcaf(string produced, string name, int length, int height, string material)
         : base(produced)
        {
            this.name = name;
            this.length = length;
            this.height = height;
            this.material = material;
        }

        public Shcaf(string produced, int length, int height, string material)
            : base(produced)
        {
            name = "Noname";
            this.length = length;
            this.height = height;
            this.material = material;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Material
        {
            get => material;
            set => material = value;
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
            return $"Произведенно в:{Produced} Имя:{name} Длина:{length} Высота:{height} Материал:{material}";
        }
    }
}