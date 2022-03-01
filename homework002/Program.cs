// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void SecondNumber(int Number)
{
   if (Number >= 100 && Number <= 999)
   {
      int n1 = Number / 10;
      int n2 = n1 % 10;
      Console.WriteLine("Вторая цифра введенного Вами числа - это " + n2);

   }
   else
   {
      Console.WriteLine("Вы ввели не трехзначное число. Попробуйте еще раз, введите dotnet run. ");
   }

}

Console.Write("Введите трехзначное число: ");
int NumberUser = Convert.ToInt32(Console.ReadLine());

SecondNumber(NumberUser);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber(int number)
{
   int count = 10;
   while (number >= 1000)
   {
      number = number / 10;
      count = count * 10;
   }

   if (number >= 100 && number <= 999)
   {
      number = number % 10;
      Console.WriteLine("Третья цифра в введенном Вами числе - это " + number);
   }
   else
   {
      Console.WriteLine("Третьей цифры в введенном Вами числе нет. ");
   }
}

Console.Write("Введите любое число и узнаете, какая цифра третья в этом числе: ");
int numberUser = Convert.ToInt32(Console.ReadLine());

ThirdNumber(numberUser);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void WeekDay(int numberWD)
{
   switch (numberWD)
   {
      case 1:

         Console.WriteLine("Понедельник не является выходным днем. Попробуй еще раз, введи: dotnet run. ");
         break;

      case 2:

         Console.WriteLine("Вторник не является выходным днем. Попробуй еще раз, введи: dotnet run. ");
         break;

      case 3:

         Console.WriteLine("Среда не является выходным днем. Попробуй еще раз, введи: dotnet run. ");
         break;

      case 4:

         Console.WriteLine("Четверг не является выходным днем. Попробуй еще раз, введи: dotnet run. ");
         break;

      case 5:

         Console.WriteLine("Пятница не является выходным днем. Попробуй еще раз, введи: dotnet run. ");
         break;

      case 6:

         Console.WriteLine("Ура! Суббота! И это выходной день! ");
         break;

      case 7:

         Console.WriteLine("Ура! Воскресение! И это выходной день! ");
         break;

      default:

         Console.WriteLine("Такого дня недели не существует. Попробуй снова, введи: dotnet run");
         break;
   }
}

Console.Write("Введите цифру, соответствующую дню недели и узнаешь, будет ли этот день выходным: ");
int numberUser = Convert.ToInt32(Console.ReadLine());

WeekDay(numberUser);
