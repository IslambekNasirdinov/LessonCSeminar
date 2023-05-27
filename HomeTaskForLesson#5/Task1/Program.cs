int[] array = generateArray();

int chetnie = 0;
int neChetnie = 0;
for (int i=0; i<array.Length; i++){
    if (array[i]%2 == 0){
        chetnie ++;
    } else{
        neChetnie++;
    }
    
}

Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Четные числа: {chetnie}");
Console.WriteLine($"Не Четные числа: {neChetnie}");

int[] generateArray(){
int[] array =  new int[12];
for ( int i=0; i< array.Length; i++){
    array[i] = new Random().Next(100,999);
}
return array;
}

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/