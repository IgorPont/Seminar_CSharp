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
*/

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

Console.Write("Введите число: ");
int numberUser = Convert.ToInt32(Console.ReadLine());

ThirdNumber(numberUser);



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.