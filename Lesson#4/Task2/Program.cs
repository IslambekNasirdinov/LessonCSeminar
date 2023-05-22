Console.WriteLine("Введите число для определение его длины");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"->{countNumber(number)}");

int countNumber(int a)
{
   int count = 0;
   while (a > 0)
   {
      int b = a % 10;
      count +=1;
      a/=10;
   }
   return count;
}


/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
