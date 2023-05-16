Console.WriteLine("Введите координаты первого точки ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты третьей точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты четвертой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());
int squareX = ((x1-x)*(x1-x));
int squareY = ((y1-y)*(y1-y));

double Length = Math.Sqrt(squareX+squareY);
Console.WriteLine(Length);