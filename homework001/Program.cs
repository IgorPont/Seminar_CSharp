/*
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
   Console.WriteLine("Первое число (" + number1 + ") больше второго (" + number2 + ") ");
}
else
{
   Console.WriteLine("Второе число (" + number2 + ") больше первого (" + number1 + ") ");
}

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine("Максимальным из введенных чисел является число " + max);

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
   Console.WriteLine("Ноль также явялется четным числом, так как обладает всеми свойствами, которые присущи чётным числам (целое число, которое делится на 2 без остатка) ");
}
else
{
   if (number % 2 == 0)
   {
      Console.WriteLine("Вы ввели четное число ");
   }
   else
   {
      Console.WriteLine("Введенное Вами число не является четным ");
   }

}
*/

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введи натуральное число, а я покажу тебе все четные натуральные числа, которые следуют перед ним ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number;

if (number > 1)
{
   if (number % 2 == 0)
   {
      Console.Write("Вот все натуральные четные числа, которые соответствют запросу: ");
      while (count > 1)
      {
         Console.Write(count + " ");
         count -= 2;
      }

   }
   else
   {
      Console.Write("Вот все натуральные четные числа, которые соответствют запросу: ");
      count = count - 1;
      while (count > 1)
      {
         Console.Write(count + " ");
         count -= 2;
      }
   }

}
else
{
   if (number == 1)
   {
      Console.WriteLine("К сожалению, четных натуральных чисел, предшествующих введенному тобой числу, я не нашел. Попробуй снова, введи: dotnet run ");
   }

   if (number < 1)
   {
      Console.WriteLine("Ты ввел ненатуральное число. Отрицательное число или ноль не являются натуральными. Попробуй снова, введи: dotnet run ");
   }

}