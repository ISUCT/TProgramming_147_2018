using System;

namespace Fauna
{
    public class Fox
    {
        private string gender;
        private string color;
        private int weight;
        private int growth;

        public Fox(string gender, string color, int weight, int growth)
        {


            this.Gender = gender;
            this.Color = color;
            this.Weight = weight;
            this.Growth = growth;
        }

        public Fox(string gender, int weight)
            : this(gender, string.Empty, weight, 0)
        {
        }

        public string Gender
        {
            get => gender;
            set
                {
                if (value == $"Male")
                {
                    gender = value;
                }
                else if (value == $"Female")
                {
                    gender = value;
                }
                else
                {
                    gender = $"Unknow";
                }

            }
         

        }

        public string Color
        {
            get => color;
            set
            {
                if (value == $"White")
                {
                    color = value;
                }
                else if (value == $"Blond")
                {
                    color = value;
                }
                else if (value == $"Red")

                {
                    color = value;
                }
                else if (value == string.Empty)
                {
                    color = $"UnknowColor";
                }
                else
                {
                    color = $"UnknowColor";
                }

            }
        }

        public int Weight
        {
            get => weight;
            set
            {
                weight = value > 0 ? value : 0;
            }
        }

        public int Growth
        {
            get => growth;
            set
            {
                growth = value > 0 ? value : 0;
            }
        }

        public void GetInfo() => Console.WriteLine($"Пол: {gender}  Цвет: {color}  Вес:  {weight}  Рост: {growth}");
    }
}