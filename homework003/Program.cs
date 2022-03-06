// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int InvertNumber(int number)
{
   int n5 = number % 10;
   int n4 = (number / 10) % 10;
   int n3 = (number / 100) % 10;
   int n2 = (number / 1000) % 10;
   int n1 = number / 10000;
   int invNum = (n5 * 10000) + (n4 * 1000) + (n3 * 100) + (n2 * 10) + n1;
   return invNum;
}

Console.Write("Введи пятизначное число и проверь, является ли оно палиндромом: ");
int numberUser = Convert.ToInt32(Console.ReadLine());

if (numberUser >= 10000 && numberUser <= 99999)
{
   int newNum = InvertNumber(numberUser);
   if (newNum == numberUser)
   {
      Console.WriteLine("Введенное Вами число является палиндромом. ");
   }
   else
   {
      Console.WriteLine("Это не число-палиндром. Попробуйте еще раз. ");
   }
}
else
{
   Console.WriteLine("Вы ввели не пятизначное число. Попробуйте еще раз. ");
}