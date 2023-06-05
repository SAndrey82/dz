//Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] array = new int[,]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        Console.Write("Введите значение элемента: ");
        int searchValue = int.Parse(Console.ReadLine());

        bool found = false;
        int positionX = -1;
        int positionY = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == searchValue)
                {
                    found = true;
                    positionX = i;
                    positionY = j;
                    break;
                }
            }
            if (found)
                break;
        }

        if (found)
        {
            Console.WriteLine("Элемент найден на позиции ({0}, {1})", positionX, positionY);
        }
        else
        {
            Console.WriteLine("Такого элемента в массиве нет");
        }