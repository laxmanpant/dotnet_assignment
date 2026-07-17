using System;
namespace multidimensional_array
{

    class Program
    {
        static void Main()
        {

            int[,] numbers = new int[3, 4];

            // writing the value 
            numbers[0, 0] = 111;
            numbers[0, 1] = 22;
            numbers[0, 2] = 33;
            numbers[0, 3] = 44;

            numbers[1, 0] = 55;
            numbers[1, 1] = 66;
            numbers[1, 2] = 77;
            numbers[1, 3] = 88;

            numbers[2, 0] = 99;
            numbers[2, 1] = 11;
            numbers[2, 2] = 22;
            numbers[2, 3] = 33;

            // Display  the matrix
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}