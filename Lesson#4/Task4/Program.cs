
int[] points = new int[8];
for (int i = 0; i < points.Length; i++)
{
   points[i] = new Random().Next(0, 1);
}
Console.WriteLine(points);
/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/