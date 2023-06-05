//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[,]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rowCount = array.GetLength(0);
        int columnCount = array.GetLength(1);

        double[] columnAverages = new double[columnCount];

        for (int column = 0; column < columnCount; column++)
        {
            int sum = 0;

            for (int row = 0; row < rowCount; row++)
            {
                sum += array[row, column];
            }

            columnAverages[column] = (double)sum / rowCount;
        }

        Console.WriteLine("Среднее арифметическое каждого столбца:");

        for (int column = 0; column < columnCount; column++)
        {
            Console.WriteLine(columnAverages[column]);
        }