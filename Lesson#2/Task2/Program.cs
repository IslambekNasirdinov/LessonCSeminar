int number = new Random().Next(100,999);
int a = number /10;
int b =a /10;
int c = number %10 ;

Console.WriteLine(number);
Console.WriteLine($"{b}{c}");
