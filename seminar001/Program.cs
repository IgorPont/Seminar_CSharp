/*

// example 001 square number

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;

Console.Write("Квадрат данного числа равен ");
Console.WriteLine(square);
*/

// example 002 comparison of two numbers

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
   Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
   Console.WriteLine("Первое число не является квадратом второго числа");
}
