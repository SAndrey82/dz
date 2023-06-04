//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] array = new int[10]; 

        Random rand = new Random();

        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(100, 1000);
        
            Console.Write(array[i] + " ");
        }

        int evenCount = 0;

        
        
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine($"Количество четных чисел: {evenCount}");