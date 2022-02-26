// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
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
*/

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
