

int[] array = generateArray();

int min = array[0];
int max = array[0];
for (int i=0; i<array.Length; i++){
    if (array[i]>max){
        max = array[i];
    }
    else if (array[i]< min)
    {
        min = array[i];
    }
}

Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Максимальное число массива:{max}");
Console.WriteLine($"Минимальное число массива: {min}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

int[] generateArray(){
int[] array =  new int[6];
for ( int i=0; i< array.Length; i++){
    array[i] = new Random().Next(1,100);
}
return array;
}

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Диапазон [-10, 10]. Обратите внимание на вещественных чисел
Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76
*/