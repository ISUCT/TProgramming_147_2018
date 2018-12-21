using System;

namespace Samolet
{
    public class Airplane
    {
        private string name;
        private int speed;

        public Airplane(int speed, string name)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public Airplane(int speed)
            : this(speed, "Noname")
        {
        }

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

        public string GetInfo()
        {
            return $"Имя: {name}  Скорость: {speed}";
        }
    }
}
