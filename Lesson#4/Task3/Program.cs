// See https://aka.ms/new-console-template for more information

int Sum(int number){
    int sum = 1;
    for (int i=1; i<=number; i++){
        sum *= i;
    }
    return sum;
}
int result = Sum(4);
Console.WriteLine(result);

/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/