Console.WriteLine("Введите трехзначную числу");
int number = Convert.ToInt32(Console.ReadLine());
int a = number % 100;
int b = a / 10;
Console.WriteLine(b);