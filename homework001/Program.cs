// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
   Console.Write("Первое число (" + number1 + ") больше второго (" + number2 + ") ");
}
else
{
   Console.Write("Второе число (" + number2 + ") больше первого (" + number1 + ") ");
}