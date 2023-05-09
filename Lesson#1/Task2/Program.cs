Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a / b == b)
{
   Console.WriteLine("Квадрат второго числа равен на первое число");
   Console.WriteLine(b);
}
else
{
   Console.WriteLine("Квадрат второго числа не равен на первое число");
}