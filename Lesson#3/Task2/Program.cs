Console.WriteLine("Введите число");
int quater = Convert.ToInt32(Console.ReadLine());

if (quater == 1){
    Console.WriteLine("x > 0, y > 0");
} else if (quater == 2){
    Console.WriteLine("x < 0, y > 0");
} else if (quater == 3){
    Console.WriteLine("x < 0, y < 0");
} else if (quater == 4){
    Console.WriteLine("x > 0, y < 0");
} else {
    Console.WriteLine("Некоректный номер");
}
