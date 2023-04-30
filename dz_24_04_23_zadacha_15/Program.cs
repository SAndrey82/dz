//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write ("Введите число: ");


int number = Convert.ToInt32(Console.ReadLine());

if (number < 8)

    if (number < 5)
           
        Console.Write ("Это не выходной день");
           
    else

        Console.Write ("Это выходной день");

else

Console.Write ("Это не число дня недели");
    

