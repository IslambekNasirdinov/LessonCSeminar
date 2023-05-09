Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
   case 1:
      Console.WriteLine("Сегодня понидельник");
      break;
   case 2:
      Console.WriteLine("Сегодня вторник");
      break;
   case 3:
      Console.WriteLine("Сегодня Среда");
      break;
   case 4:
      Console.WriteLine("Сегодня четверк");
      break;
   case 5:
      Console.WriteLine("Сегодня пятница");
      break;
   case 6:
      Console.WriteLine("Сегодня суббота");
      break;
   case 7:
      Console.WriteLine("Сегодня воскресения");
      break;
   default:
      Console.WriteLine("Нет токого дня недели!");
      break;
}

