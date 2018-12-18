using System;

namespace ConsoleApp2
{
    using System;

    public abstract class Furniture
    {
        private string produced;

        public Furniture(string produce) => Produced = produce;

       public string Produced { get => produced; set => produced = value; }
    }
}