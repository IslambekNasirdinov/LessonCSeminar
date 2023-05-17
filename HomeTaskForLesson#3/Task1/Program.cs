Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
string a = number.ToString();
char[] array = a.ToCharArray();
Array.Reverse(array);
a = new String(array);
int b = Convert.ToInt32(a);

if (number == b)
{
   Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет");
}




/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
