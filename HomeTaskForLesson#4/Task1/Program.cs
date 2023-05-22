
int stepen(int a, int b)
{
    int sum = 1;
    for (int i = 1; i <= b; i++)
    {
      sum *=a;
    }
    return sum;
}

int result = stepen(2,4);
Console.WriteLine( result);


/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/