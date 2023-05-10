
int number = new Random().Next(10,99);
int a = number / 10;
int b = number % 10;
if (a>b){
    Console.WriteLine($"Our number is {number}. {a}>{b}. Result{a}");
}
else if(a<b)
{
    Console.WriteLine($"Our number is {number}. {b}>{a}. Result{b}");
}
else{
    Console.WriteLine($"Our number is {number}. {a}={b}");
}
