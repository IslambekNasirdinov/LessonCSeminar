﻿Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число из трех введенных вами чисел = ");
Console.WriteLine(max);