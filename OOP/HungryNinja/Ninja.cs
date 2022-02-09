using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public string Name;
        public List<Food> FoodHistory;
        // add a constructor
        public Ninja(string name)
        {
            Name = name;
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get 
            {
                return calorieIntake >= 1200;
            }
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            if(!IsFull)
            {
                FoodHistory.Add(item);
                calorieIntake += item.Calories;
                int caloriesLeft = 1200 - calorieIntake;
                if (caloriesLeft >= 0)
                {
                    Console.WriteLine($"{Name} has enjoyed {item.Name}! Only {caloriesLeft} until full!");
                }
            }
            else
            {
                Console.WriteLine($"{Name} is full. Can't eat anymore.");
            }
        }
    }


}