int a =1;
int b = 5;

void Recurs(int a, int b){
    if (a<=b){
        Console.WriteLine(a);
        a++;
        Recurs(a,b);
    }
    else
    return;
}

Recurs(a,b);

/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/