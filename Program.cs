﻿// Первая задача 
// Console.Write("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 < num2)
// {
//     Console.WriteLine($"Число {num2} больше {num1}");
// }
// else Console.WriteLine($"Число {num1} больше {num2}");

//Вторая задача
// Console.Write("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if(num1 < num2)
// {
//     if(num2<num3) 
//     {
//          Console.WriteLine($"Число {num3} максимальное");
//     }
//     else        
//         Console.WriteLine($"Число {num2} максимальное");    
// }
// else
// {
//     if(num1<num3)
//     { 
//         Console.WriteLine($"Число {num3} максимальное");
//     } 
//     else
//         Console.WriteLine($"Число {num1} максимальное");    
// }

//Третья задача
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
{
    Console.WriteLine($"Число {num} четное");    
}
else Console.WriteLine($"Число {num} не четное");