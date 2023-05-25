//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");

int A = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int Number = A;

while (Number != 0)
    {
        int Number_B = Number % 10;
        sum += Number_B;
        Number /= 10;
    }

Console.WriteLine("Сумма цифр числа: " + sum);