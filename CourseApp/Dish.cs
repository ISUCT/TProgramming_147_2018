using System;

namespace Menu
{
    public class Dish
    {
        private string name;
        private int price;
        private string type;
        private int weight;

        public Dish(string name, int price, string type, int weight)
        {
            if (name == $"Cesar")
            {
                this.name = name;
            }
            else
            {
                this.name = $"NoName";
            }

            if (price >= 0)
            {
                this.price = price;
            }
            else
            {
                this.price = 0;
            }

            if (type == $"Salad")
            {
                this.type = type;
            }
            else
            {
                this.type = $"NoType";
            }

            this.type = type;
            if (weight >= 0)
            {
                this.weight = weight;
            }
            else
            {
                this.weight = 0;
            }
        }

        public Dish(string name, int price)
        {
            if (name == $"chees")
            {
                this.name = name;
            }
            else
            {
                this.name = $"NoName";
            }

            if (price >= 0)
            {
                this.price = price;
            }
            else
            {
                this.price = 0;
            }
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Price
        {
            get => price;
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                           }
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public int Weight
        {
            get => weight;
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                            }
        }

        public void GetInfo() => Console.WriteLine($"Название: {name}  Цена: {price}   Тип: {type}   Вес: {weight}");
    }
}
