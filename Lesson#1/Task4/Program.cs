Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a = N * -1;

while (a <= N)
{
   Console.Write(a);
   Console.Write(" ");
   a++;
}
