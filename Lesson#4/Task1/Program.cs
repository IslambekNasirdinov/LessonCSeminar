
int Sum(int a)
{
   int sum = 0;
   for (int i = 1; i < a; i++)
   {
      sum += i;
   }
   return sum;
}

int result = Sum(4);
Console.WriteLine(result);

/*
Демонстрация решения
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/