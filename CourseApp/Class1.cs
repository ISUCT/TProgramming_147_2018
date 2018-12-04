using System;
namespace ConsoleApp2
{
    using System;
    public class Car
    {
        private string name;
        private int speed;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Speed
        {
            get => speed;
            set
            {
                if (value > 0)
                {
                    speed = value;
                }
            }
        }
        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }
        public Car(int Speed)
        {
            this.name = "Noname";
            this.speed = speed;
        }
        public string GetInfo()
        {
            return $"Имя: {name}  скорость: {speed} ";
        }
    }
}