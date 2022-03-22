// ==== Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵); 2, 4 -> 16
/*
double NumberDegree(int num, int deg) // учтены все варианты (0^n; n^0; -n^n; n^-n; -n^-n)
{
   if (num != 0)
   {
      int result = 1;
      for (int i = 0; i < Math.Abs(deg); i++)
      {
         result *= num;
      }
      if (deg >= 0)
      {
         return result;
      }
      else
      {
         double div = 1.0 / result;
         return div;
      }
   }
   else return 0;
}

Console.Write("Enter the number you want to raise to the natural degree: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the natural degree to which you want to put the number: ");
int degreeUser = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The number {numberUser} to the power of {degreeUser} is {NumberDegree(num: numberUser, deg: degreeUser)}.");
Console.WriteLine();
*/

// ==== Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11; 82 -> 10; 9012 -> 12

int SumNumberNum(int num)
{
   if (num != 0)
   {
      num = Math.Abs(num);
      int count = 0;
      int newNum = num;
      for (int a = 0; newNum > 0; a++)
      {
         newNum /= 10;
         count++;
      }

      int remDiv = 10;
      int result = num % remDiv; ;
      for (int i = 0; i < count; i++)
      {
         remDiv *= 10;
         result += (num % remDiv) / (remDiv / 10);
      }
      return result;
   }
   else return 0;
}

Console.Write("Enter a number and get the sum of digits of that number: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"The sum of digits in the entered number is {SumNumberNum(numberUser)}. ");
Console.WriteLine();

// Решение второй задачи через строку.
/*
int SumNumberNum(string num) // есть баг, на отрицательное число выдает ошибку
{
   int result = 0;
   for (int i = 0; i < num.Length; i++)
   {
      result += int.Parse(num[i].ToString());
   }
   return result;
}

Console.Write("Enter a number and get the sum of digits of that number: ");
string numberUser = Console.ReadLine();
Console.WriteLine($"The sum of digits in the entered number is {SumNumberNum(numberUser)}. ");
*/

// ==== Задача 3: Напишите программу, которая задаёт массив из 8 элементов, запрашивает числа у пользователя, заполняет ими массив и выводит заданный массив на экран.

