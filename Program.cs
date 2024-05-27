using System;

namespace Homework2;
public class Program
{
    public static void Main(string[] args)
    {
        int[,] array = new int[3, 3] { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int[] sort = new int[rows * cols];
        Console.Write("Изначальный массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sort[i * rows + j] = array[i, j];
                Console.Write(array[i, j] + " ");
            }
        }
        Array.Sort(sort);
        Console.Write("\nОтсортированный массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = sort[i * rows + j];
                Console.Write(array[i, j] + " ");
            }
        }
        Console.ReadKey();
    }
}
