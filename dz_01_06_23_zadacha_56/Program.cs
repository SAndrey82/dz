//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int smallestSumRow = FindSmallestSumRow(array);
        Console.WriteLine($"Номер строки с наименьшей суммой элементов: {smallestSumRow + 1}");
    }

    static int FindSmallestSumRow(int[,] array)
    {
        int smallestSum = int.MaxValue;
        int smallestSumRow = -1;

        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < colCount; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < smallestSum)
            {
                smallestSum = rowSum;
                smallestSumRow = i;
            }
        }

        return smallestSumRow;
    }
}
