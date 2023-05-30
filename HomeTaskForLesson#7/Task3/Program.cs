
int [,] array = new int [3,3];
double[] ArifNumbers = new double[array.GetLength(1)];
for(int i=0; i < array.GetLength(0); i++){
    double result = 0.0;
    for (int j=0; j<array.GetLength(1); j++){
        result += array[j,i];
        array[i,j] = new Random().Next(1,10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
    ArifNumbers[i] = result / array.GetLength(0);
    Console.WriteLine($" Среднее арифметическое число: {ArifNumbers[i]}");
}
// Задание выполнено не корекно 
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/