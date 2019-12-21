using System;

namespace Lab_03_2program
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] array = new int[7, 7];
            int randomElement = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    randomElement = rand.Next(0, 9);
                    array[i, j] = randomElement;
                }
            }
            Console.WriteLine("The matrix is ");
            WriteMatrix(array);
            Console.WriteLine();
            int reserv = 0;
            int sizeList = 0;
            RotateMatrix(array, reserv, sizeList);
            WriteMatrix(array);
            Console.ReadKey();
        }
        static void WriteMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void RotateMatrix(int[,] array, int reserv, int sizeList)
        {
            sizeList = array.GetLength(0);
            for (int i = 0; i < array.GetLength(0) / 2; i++)
            {
                for (int j = i; j < sizeList - 1 - i; j++)
                {
                    reserv = array[i, j];
                    array[i, j] = array[sizeList - j - 1, i];
                    array[sizeList - j - 1, i] = array[sizeList - i - 1, sizeList - j - 1];
                    array[sizeList - i - 1, sizeList - j - 1] = array[j, sizeList - i - 1];
                    array[j, sizeList - i - 1] = reserv;
                }
            }
        }
    }
}