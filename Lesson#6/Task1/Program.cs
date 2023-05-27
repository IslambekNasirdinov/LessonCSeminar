
int GetArray(int length){
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10,11);
    }
    return array;
}

void Reverse(int[] array){
    for (int i=0; i<array.Length / 2; i++){
        int tap = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length -1 -i]= tap;
    }
}
console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.Readline());
int[]
/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/