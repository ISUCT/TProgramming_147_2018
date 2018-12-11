using System;

namespace Menu
{
    public class Dish
    {
        private string name;
        private int price;
        private string type;
        private int weight;
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
                else Console.WriteLine($"Цена не может быть отрицательной");
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
        public Dish(string name, int price, string type, int weight)
        {
            this.name = name;
            this.price = price;
            this.type = type;
            this.weight = weight;
        }
        public Dish(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название: {name}  Цена: {price}   Тип: {type}   Вес: {weight}");

        }
    }
}


