﻿Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[4,4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0 ; j < array.GetLength(1); j++){
        array[i,j] = new Random().Next(1,100);
        Console.Write(array[i,j] + " ");
}
Console.WriteLine();
}
if (number < array.GetLength(0) && number< array.GetLength(1)){
    Console.WriteLine($"Есть такой индек в массиве, его значение: {array[number, number]}");
} else{
    Console.WriteLine($"Нет такого индекса в массиве: {number}");
}


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/