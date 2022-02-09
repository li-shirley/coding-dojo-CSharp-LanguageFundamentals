using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty List of type object
            List<object> Box = new List<object>() 
            // Add the following values to the list: 7, 28, -1, true, "chair"
            {
                7, 28, -1, true, "chair"
            };
            // Loop through the list and print all values 
            foreach (object i in Box)
            {
                Console.WriteLine(i);
            }
            // Add all values that are Int type together and output the sum
            int sum = 0;
            foreach (object i in Box)
            {
                if (i is int){
                    sum = sum + (int)i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
