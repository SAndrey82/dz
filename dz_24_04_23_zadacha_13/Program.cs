//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write ("Введите число: ");


int number = Convert.ToInt32(Console.ReadLine());

if (number > 100)

{
int a = number / 1000;

int b = a * 1000;

int c = number - b;

int d = c / 100;

Console.Write ("Второе число: ");
Console.WriteLine (d);
}
else

 Console.Write ("Третей цыфры нету");  