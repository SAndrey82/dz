//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8



Console.Write ("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = 2;

Console.Write("Четные числа ");

if (a > 1) 
    
    while (b <= a)
{  
    Console.Write(b + " "); 
    b += 2;          
}   

else Console.Write("НЕТ четных чисел");


