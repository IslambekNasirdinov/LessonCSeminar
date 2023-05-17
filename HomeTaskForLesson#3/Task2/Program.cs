Console.WriteLine("Введите координаты точки А ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
int z1 = Convert.ToInt32(Console.ReadLine());

int squareX = ((x1 - x) * (x1 - x));
int squareY = ((y1 - y) * (y1 - y));
int squareZ = ((z1 - z) * (z1 - z));

double Length = Math.Sqrt(squareX + squareY + squareZ);
Console.WriteLine(Length);



/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/