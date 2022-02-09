using System;

namespace BasicThirteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions.PrintNumbers();

            Functions.PrintOdds();

            Functions.PrintSum();

            int[] arr = new int[] {1,2,3,21,4,5,6,7};
            Functions.LoopArray(arr);

            Functions.FindMax(arr);

            Functions.GetAverage(arr);

            Functions.OddArray();

            Functions.GreaterThanY(arr, 2);

            Functions.SquareArrayValues(arr);

            int[] arr2 = new int[] {1,-2,3,-4,5};
            Functions.EliminateNegatives(arr2);

            Functions.MinMaxAverage(arr2);

            Functions.ShiftValues(arr2);

            Functions.NumToString(arr2);
        }
    }
}
