using System;

namespace ConsoleApp2
{
    using System;

    public class Class11
    {
        private string name;
        private int speed;

        public Class11(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public Class11(int speed)
        {
            name = "Noname";
            this.speed = speed;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set => name = value;
        }

        public int Speed
        {
            get
            {
                return speed;
            }

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
            return $"Имя: {name}  скорость: {speed} ";
        }
    }
}