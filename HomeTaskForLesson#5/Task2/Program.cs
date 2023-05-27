
int[] array = generateArray();

int sumNeChetnit = 0;
for (int i=0; i<array.Length; i++){
    if (i%2 != 0){
        sumNeChetnit += array[i];
    }
   
}

Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма не четных чисел: {sumNeChetnit}");


int[] generateArray(){
int[] array =  new int[4];
for ( int i=0; i< array.Length; i++){
    array[i] = new Random().Next(1,10);
}
return array;
}

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/