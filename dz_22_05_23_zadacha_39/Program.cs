﻿//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Random rand = new Random();
        int[] array = new int[4]; 

        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-100, 100); 
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();

        int sum = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            
            if (i % 2 != 0)
            {
                sum += array[i];
            }
        }

        Console.WriteLine("Сумма элементов на нечетных позициях равна " + sum);