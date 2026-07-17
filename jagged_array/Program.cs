using System;
namespace jagged_array
{
    class Program
    {
        static void Main()
        {

            int[][] numbers = new int[3][];


            numbers[0] = new int[] { 1, 2, 37 };
            numbers[1] = new int[] { 4, 5 };
            numbers[2] = new int[] { 6, 7, 8, 9 };

            // Displaying  the  jagged array
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}