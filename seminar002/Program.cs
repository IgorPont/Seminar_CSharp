// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int FindMaxNum(int num) // метод
{
   int n1 = num % 10;
   int n2 = num / 10;

   if (n1 > n2)
   {
      return n1;
   }
   else
   {
      return n2;
   }
}

int number = new Random().Next(10, 99);
Console.WriteLine("Current number is " + number + " max part is " + FindMaxNum(number));


// Задача 2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int FindMaxNum(int num) // метод
{
   int n1 = num / 100;
   int n2 = num % 10;

   int n3 = n1 * 10 + n2;
   return n3;
}

int number = new Random().Next(100, 999);
Console.WriteLine("Вот Ваше число: " + number + " вот число без второго разряда: " + FindMaxNum(number));
*/

// Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деление.

void MultipleNumber(int Number1, int Number2)
{
   if (Number1 % Number2 == 0)
   {
      Console.WriteLine("Введенные Вами второе число кратно первому ");
   }
   else
   {
      Console.WriteLine("Введенные Вами второе число не явялется кратным первому. Остаток от деления равен: " + (Number1 % Number2));
   }
}

Console.Write("Чтобы проверить кратность двух чисел, введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
MultipleNumber(Number1, Number2);


// Задача 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23 (дополнение к задаче: пользователь должен сам вводить числа)
