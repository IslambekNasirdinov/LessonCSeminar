

/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.WriteLine("Введите длину массива:");
int arrayLen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту массива:");
int arrayH = Convert.ToInt32(Console.ReadLine());




int[,] array2d = new int[arrayLen,arrayH];


for (int i=0; i < array2d.GetLength(0); i++)
{
    for (int j=0; j < array2d.GetLength(1); j++)
    {
        array2d[i,j] = new Random().Next(1,10);
        
        
        Console.Write(array2d[i,j] + " ");


    }
    Console.WriteLine();
}

int k = 0;
int[] arrayTemp = new int[arrayLen*arrayH];
for (int i=0; i < array2d.GetLength(0); i++)
{
    

    for (int j=0; j < array2d.GetLength(1); j++)
    {
        arrayTemp[k] = array2d[i,j];
        k++;
    }
}
Console.WriteLine(string.Join(",",arrayTemp));

Array.Sort(arrayTemp);

int count = 0;
int element = arrayTemp[0];
foreach (int i in arrayTemp)
{
    if (i==element) count++;
    else
    {
        
        Console.WriteLine($"Число {element} встечается {count}");
        element=i;
        count =1;
    }

}

Console.WriteLine($"Число {element} встечается {count}");

Console.WriteLine(string.Join(",",arrayTemp));