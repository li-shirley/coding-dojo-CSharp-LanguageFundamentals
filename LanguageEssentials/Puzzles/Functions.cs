using System;
using System.Collections.Generic;
namespace Puzzles
{
    class Functions
    {
        public static int[] RandomArray()
        {
            int[] array = new int[10];
            Random num = new Random();
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            for (int idx = 0; idx < array.Length; idx++)
            {
                array[idx] = num.Next(5,25);
                if (array[idx] < min)
                    min = array[idx];
                else if (array[idx] > max)
                    max = array[idx];
                sum += array[idx];
            }
            Console.WriteLine($"Min: {min}, Max: {max}, Sum: {sum}");
            // foreach (int value in array)
            // {
            //     Console.WriteLine(value);
            // }
            return array;
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random toss = new Random();
            string result = null;
            int flip = toss.Next(1,3);
            if (flip == 1)
                result = "Tails";
            else
                result = "Heads";
            // Console.WriteLine(flip);
            Console.WriteLine(result);
            return result;
        }
        public static double TossMultipleCoins(int num)
        {
            Random toss = new Random();
            int headCount = 0;
            for(int i = 0; i < num; i++)
            {
                if(toss.Next(1,3) == 1)
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
            }
            Console.WriteLine((double)headCount/num);
            return (double)headCount/num;
        }
        public static List<string> Names()
        {
            List<string> names = new List<string>()
            {
                "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
            };
            Random spot = new Random();
            for(int idx = 0; idx<5; idx++)
            {
                int newSpot = spot.Next(5);
                string temp = names[newSpot];
                names[newSpot] = names[idx];
                names[idx] = temp;
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            for(int idx = 0; idx<5; idx++)
            {
                if(names[idx].Length <= 5)
                {
                    names.RemoveAt(idx);
                }
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            return names;
        }
    }
}