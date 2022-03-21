// ==== Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int SumNumber(int num)
{
   int sum = 0;
   for (int i = 1; i <= num; i++)
   {
      sum += i;
   }
   return sum;
}

Console.Write("Inter a number: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The sum of the numbers from 1 to " + numberUser + " is " + SumNumber(numberUser));


// ==== Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int NumerNum(int num)
{
   int count = 0;
   while (num != 0)
   {
      num = num / 10;
      count++;
   }
   return count;
}

Console.Write("Inter a number: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The number of digits in the number you entered is " + NumerNum(numberUser));


// ==== Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int ProductNumber(int num)
{
   int result = 1;
   for (int i = 1; i <= num; i++)
   {
      result *= i;
   }
   return result;
}

Console.Write("Inter a number: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The product of the numbers from 1 to " + numberUser + " is " + ProductNumber(numberUser));
*/

// ==== Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void BinaryArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(0, 2);
      Console.Write($"{array[i]} ");
   }
}

int[] arrayUser = new int[8];
BinaryArray(arrayUser);
Console.ReadLine();
