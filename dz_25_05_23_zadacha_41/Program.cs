//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < M; i++)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел больше нуля: " + count);