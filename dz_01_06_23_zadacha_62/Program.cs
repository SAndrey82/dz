//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int n = 4;
        int[,] array = new int[n, n];

        int value = 1;
        int minRow = 0, maxRow = n - 1, minCol = 0, maxCol = n - 1;

        while (value <= n * n)
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                array[minRow, i] = value;
                value++;
            }
            minRow++;

            for (int i = minRow; i <= maxRow; i++)
            {
                array[i, maxCol] = value;
                value++;
            }
            maxCol--;

            for (int i = maxCol; i >= minCol; i--)
            {
                array[maxRow, i] = value;
                value++;
            }
            maxRow--;

            for (int i = maxRow; i >= minRow; i--)
            {
                array[i, minCol] = value;
                value++;
            }
            minCol++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }