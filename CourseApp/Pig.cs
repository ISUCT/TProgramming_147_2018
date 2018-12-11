using System;

namespace ConsoleApp2
{
using System;
public class Pig
{
    private string name;
    private int age;
    private int weight;
    public string Name;
           public Pig(string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }
        public Pig(int age, int weight)
        {
            this.name = "Noname" ;
            this.age = age;
            this.weight = weight;
        }
    
        get => name        
        set => name = value;
        }
    }
        public int age
    {
            get => age;
            set
            {
                if (value > 10)
                {
                    age = value;
                }
            }
        }
        public int weight
        {
            get => weight;
            set
            {
                if (value > 70)
                {
                    weight = value;
                }
            }
        }

        public string GetInfo()
        {
            return $"Имя: {Name}  возраст: {age}  вес: {weight}";
        }
    }