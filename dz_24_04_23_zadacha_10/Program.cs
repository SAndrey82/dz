//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write ("Введите трехзначное число: ");


int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number < 1000)

{
int a = number / 100;

int b = a * 100;

int c = number - b;

int d = c / 10;

Console.Write ("Второе число: ");
Console.WriteLine (d);
}
else

 Console.Write ("Вы ввели не трехзначное число");    
