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

// example 003 days of the week

Console.Write("Enter a sequential number of the day of the week ");
int numberUser = Convert.ToInt32(Console.ReadLine());

if (numberUser <= 7 && numberUser >= 1)
{

   if (numberUser == 1)
   {
      Console.Write("The number entered corresponds to ");
      Console.WriteLine("Monday");
   }

   if (numberUser == 2)
   {
      Console.Write("The number entered corresponds to ");
      Console.WriteLine("Tuesday");
   }

   if (numberUser == 3)
   {
      Console.Write("The number entered corresponds to ");
      Console.WriteLine("Wednesday");
   }

   if (numberUser == 4)
   {
      Console.Write("The number entered corresponds to ");
      Console.WriteLine("Thursday");
   }

   if (numberUser == 5)
   {
      Console.Write("The number entered corresponds to ");
      Console.WriteLine("Friday");
   }

   if (numberUser == 6)
   {
      Console.Write("The number entered corresponds to ");
      Console.WriteLine("Saturday");
   }

   if (numberUser == 7)
   {
      Console.Write("The number entered corresponds to ");
      Console.WriteLine("Sunday");
   }

}
else
{
   Console.WriteLine("There is no such day of the week ");
}
*/

// example 004 Write a program that takes one number (N) as input and displays all integers between -N and N as output

Console.Write("Enter a natural number ");
int numberUser = Convert.ToInt32(Console.ReadLine());
int negNumberUser = numberUser * (-1);

while (negNumberUser <= numberUser)
{
   Console.Write(negNumberUser);
   negNumberUser++;
}