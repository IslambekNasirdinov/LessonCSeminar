Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100){
    Console.WriteLine("Третьей цифры нету");
    
    
}else if (number > 999){
    number = number /10;
    int b = number % 10;
    Console.WriteLine(b);
}
else{
    int a = number %10;
    Console.WriteLine(a);
}


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
