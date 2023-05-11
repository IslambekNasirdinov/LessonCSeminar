int number = new Random().Next(100,999);
int a = number /100;
int b =number %10;


Console.WriteLine(number);
Console.WriteLine($"{a}{b}");
