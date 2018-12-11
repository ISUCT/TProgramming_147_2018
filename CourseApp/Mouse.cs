using System;

namespace ConsoleApp2
{

    using System;

    public class Mouse
    {
        private string name;
        private string age;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Mouse(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public Mouse(int name, int age)
        {
            this.name = "Noname";
            this.age = "age";
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name} Возраст: {age}");
        }
    }
}