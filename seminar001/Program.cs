// example 001 square number
/*
Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;

Console.Write("Квадрат данного числа равен ");
Console.WriteLine(square);

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
*/

// example 003 days of the week

string number1 = "Mondey";
string number2 = "Tuesday";
string number3 = "Wednesday";
string number4 = "Thursday";
string number5 = "Friday";
string number6 = "Saturday";
string number7 = "Sunday";

Console.WriteLine("Enter a sequential number of the day of the week from 1 to 7 ");
int number_user = Convert.ToInt32(Console.ReadLine());

if (number_user == 1)
{
   Console.Write("The number entered corresponds to ");
   Console.WriteLine(number1);
}

if (number_user == 2)
{
   Console.Write("The number entered corresponds to ");
   Console.WriteLine(number2);
}

if (number_user == 3)
{
   Console.Write("The number entered corresponds to ");
   Console.WriteLine(number3);
}

if (number_user == 4)
{
   Console.Write("The number entered corresponds to ");
   Console.WriteLine(number4);
}

if (number_user == 5)
{
   Console.Write("The number entered corresponds to ");
   Console.WriteLine(number5);
}

if (number_user == 6)
{
   Console.Write("The number entered corresponds to ");
   Console.WriteLine(number6);
}

if (number_user == 7)
{
   Console.Write("The number entered corresponds to ");
   Console.WriteLine(number7);
}
