//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да



Console.Write ("Введите число: ");


int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000 && number > 9999)

{
    int a = number / 10000;

    int b = number / 1000 % 10;

    int c = number % 100 / 10;

    int d = number % 10;
    
      
        if (a == d && b == c)
              
            Console.Write ("Ваше число палиндром");
            
        else
            
            Console.Write ("Ваше число не палиндром"); 
           
}

else

 Console.Write ("Вы ввели не пятизначное число"); 
