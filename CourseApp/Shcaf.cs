using System;

namespace ConsoleApp2
{
    using System;

    public class Shcaf : Furniture
    {
        public Shcaf()
        {
            Produced = "Russia";
            Name = "chto-to";
        }

        public Shcaf(string name)
        {
            Name = name;
        }

        public Shcaf(string produced, string name, string material)
         : base(produced, name)
        {
            Material = material;
        }

        public Shcaf(string produced, string material)
        : base(produced)
        {
            Produced = produced;
            Material = material;
        }

        public override string GetInfo()
        {
            return $"Произведенно в:{Produced} Имя:{Name} Материал:{Material}";
        }

        public override string Mebel()
        {
            return "Shcaf";
        }
    }
}