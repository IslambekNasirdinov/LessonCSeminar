Console.WriteLine("Введите длину массива:");
int arrayWith = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту массива:");
int arrayHigth = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [arrayWith,arrayHigth];

for (int i=0; i < array.GetLength(0); i++){
    for(int j=0; j < array.GetLength(1); j++){
        array[i,j] = new Random().Next(1,100);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

int [] arrayReserv = new int[array];

for (int i=0; i < array.GetLength(1); i++){
    arrayReserv[i] = array[0,i]

}


void Print2DArray(int[,] array) 
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/