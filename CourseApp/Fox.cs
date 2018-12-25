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
            if (gender == $"Male")
                {
                Gender = gender;
                }
                else if (gender == $"Female")
                {
                    Gender = gender;
                }
                else
                {
                    Gender = $"Unknow";
                }
            if (color == $"White")
            {
                Color = color;
            }
            else if (color == $"Blond")
            {
                Color = color;
            }
            else if (color == $"Red")

            {
                Color = color;
            }
            else if (color == string.Empty)
            {
                Color = $"UnknowColor";
            }
            else
            {
                Color = $"UnknowColor";
            }
                       
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
            set => gender = value;        
            
        }

        public string Color
        {
            get => color;
            set => color = value;
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