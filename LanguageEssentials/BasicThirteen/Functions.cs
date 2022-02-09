using System;

namespace BasicThirteen 
{
    public static class Functions 
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i+=2)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"New numer: {i}, Sum: {sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                Console.WriteLine(numbers[idx]);
            }
        }
        public static int? FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int idx = 1; idx < numbers.Length; idx++)
            {
                if (numbers[idx] > max)
                    max = numbers[idx];
            }
            Console.WriteLine(max);
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            double sum = 0;
            for (int idx = 0; idx < numbers.Length; idx++){
                sum += numbers[idx];
            }
            Console.WriteLine(sum/numbers.Length);
        }
        public static int[] OddArray()
        {
            int[] arr = new int[128];
            int idx = 0;
            int num = 1;
            while (num < 256)
            {
                arr[idx] = num;
                idx++;
                num += 2;
            }
            // foreach (int value in arr)
            // {
            //     Console.WriteLine(value);
            // }
            return arr;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                if (numbers[idx] > y)
                    count++;
            }
            Console.WriteLine(count);
            return count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                numbers[idx] = numbers[idx] * numbers[idx];
            }
            // for (int idx = 0; idx < numbers.Length; idx++)
            // {
            //     Console.WriteLine(numbers[idx]);
            // }
        }
        public static void EliminateNegatives(int[] numbers)
        {            
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                if (numbers[idx] < 0)
                    numbers[idx] = 0;
            }
            // for (int idx = 0; idx < numbers.Length; idx++)
            // {
            //     Console.WriteLine(numbers[idx]);
            // }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            double average = 0;
            int sum = 0;
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                if (numbers[idx] > max)
                    max = numbers[idx];
                else if (numbers[idx] < min)
                    min = numbers[idx];
                sum += numbers[idx];
            }
            average = (double)sum / numbers.Length;
            Console.WriteLine($"Min: {min}, Max: {max}, Average: {average}");
        }
        public static void ShiftValues(int[] numbers){
            for (int idx = 1; idx < numbers.Length; idx++)
            {
                numbers[idx-1]=numbers[idx];
            }
            numbers[numbers.Length-1] = 0;
            // for (int idx = 0; idx < numbers.Length; idx++)
            // {
            //     Console.WriteLine(numbers[idx]);
            // }
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] arr = new object[numbers.Length];
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                if (numbers[idx] < 0)
                    arr[idx] = "Dojo";
                else
                    arr[idx] = numbers[idx];
            }
            // foreach (object value in arr)
            // {
            //     Console.WriteLine(value);
            // }
            return arr;
        }
    }
}