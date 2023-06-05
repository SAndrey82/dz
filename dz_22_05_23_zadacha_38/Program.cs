//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Диапазон [-10, 10]. Обратите внимание на вещественных чисел
//Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76

int[] array = new int[5];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-10, 10);
}

Console.Write("Сгенерированный массив случайных чисел: ");
foreach (int element in array)
{
    Console.Write(element + " ");
}

int min = array[0];
int max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }

    if (array[i] > max)
    {
        max = array[i];
    }
}

int difference = max - min;
Console.WriteLine("\nРазница между максимальным и минимальным элементами: " + difference);
