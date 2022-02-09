using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to hold integer values 0 through 9
            int[] numArray = new int[] {0,1,2,3,4,5,6,7,8,9};
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] strArray = new string[] {"Tim", "Martin","Nikki", "Sara"};
            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArray = new bool[] {true, false, true, false, true, false, true, false, true, false};

            // Create a list of ice cream flavors that holds at least 5 different flavors
            List<string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("Chocolate");
            iceCreamFlavors.Add("Vanilla");
            iceCreamFlavors.Add("Strawberry");
            iceCreamFlavors.Add("Coffee");
            iceCreamFlavors.Add("Pistachio");
            // Output the length of this list after building it
            Console.WriteLine(iceCreamFlavors.Count);
            // Output the third flavor in the list, then remove this value
            Console.WriteLine(iceCreamFlavors[2]);
            iceCreamFlavors.RemoveAt(2);
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(iceCreamFlavors.Count);

            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> dict = new Dictionary<string,string>();
            // Add key/value pairs to this dictionary where each key is a name from your names array and each value is a randomly select a flavor from your flavors list
            foreach(var name in strArray)
                dict.Add(name, null);
            // For each name key, select a random flavor from the flavor list above and store it as the value
            Random rand = new Random();
            foreach(var name in strArray)
                dict[name] = (iceCreamFlavors[rand.Next(iceCreamFlavors.Count)]);

            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (KeyValuePair<string,string> entry in dict)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
    }
}
