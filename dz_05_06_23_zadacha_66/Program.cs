//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

class Program
{
    static void Main()
    {
        int M, N;

        Console.WriteLine("Введите значение M:");
        M = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        N = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма натуральных элементов от {M} до {N} равна {sum}");
    }
}