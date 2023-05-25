//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] arrey = new int[8];

    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"Введите значение для элемента {i + 1}: ");
        arrey[i] = Convert.ToInt32(Console.ReadLine());
    }

        
    Console.WriteLine("[" + string.Join(", ", arrey) + "]");