//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write ("Введите превое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max;



if (a > b && a > c ) max = a;
    
    else if (b > a && b > c) max = b; 

        else max = c;          
                
Console.Write ("И так Александр!!! бар-ра-бан-на-я дробь и ЭТО: ");
Console.WriteLine(max);
         
        


