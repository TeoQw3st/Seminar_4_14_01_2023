﻿// See https://aka.ms/new-console-template for more information
int Degree (int arg1, int arg2)
{
    int degree = Convert.ToInt32(Math.Pow(arg1, arg2));
    return degree;
}


Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" Если {num1} возвести в степень {num2} получится ({Degree (num1, num2)})");