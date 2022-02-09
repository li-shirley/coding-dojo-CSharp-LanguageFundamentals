using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("BLT Sandwich", 593, false, false),
                new Food("Maple Bacon Donut", 350, false, true),
                new Food("Mac and Cheese", 678, false, false),
                new Food("Buffalo Chicken Wrap", 567, true, false),
                new Food("Beer Cheese Pretzel", 730, false, false),
                new Food("Coffee Cake", 225, false, true),
                new Food("Creamy Kimchi Udon", 748, true, false),
            };
        }
        public Food Serve()
        {
            Random food = new Random();
            return Menu[food.Next(Menu.Count)];
        }
    }
}