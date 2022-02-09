using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            int j = 1;
            while (j <= 255)
            {
                Console.WriteLine(j);
                j = j + 1;
            }
            for (int k = 1; k <=100; k++)
            {
                if (k % 3 == 0 && k % 5 != 0)
                {
                    Console.WriteLine(k);
                }
                else if (k % 5 == 0 && k % 3 != 0)
                {
                    Console.WriteLine(k);
                }
            }
            int l = 1;
            while (l <= 100)
            {
                if (l % 3 == 0 && l % 5 != 0)
                {
                    Console.WriteLine(l);
                }
                else if (l % 5 == 0 && l % 3 != 0)
                {
                    Console.WriteLine(l);
                }
                l = l + 1;
            }
            for (int m = 1; m <=100; m++)
            {
                if (m % 3 == 0 && m % 5 != 0)
                {
                    Console.WriteLine(m + " Fizz");
                }
                else if (m % 5 == 0 && m % 3 != 0)
                {
                    Console.WriteLine(m + " Buzz");
                }
                else if (m % 5 == 0 && m % 3 == 0)
                {
                    Console.WriteLine(m + " FizzBuzz");
                }
            }
            int n =1;
            while (n <= 100){
                if (n % 3 == 0 && n % 5 != 0)
                {
                    Console.WriteLine(n + " Fizz");
                }
                else if (n % 5 == 0 && n % 3 != 0)
                {
                    Console.WriteLine(n + " Buzz");
                }
                else if (n % 5 == 0 && n % 3 == 0)
                {
                    Console.WriteLine(n + " FizzBuzz");
                }
                n = n + 1;                
            }
        }
    }
}
