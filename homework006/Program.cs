// ==== Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
/*
void CountPositiveNumbers(int command, int step)
{
   if (command > 0)
      step++;
   Console.Write($"Enter the number (to exit enter 'End'): ");
   var userCommand = Console.ReadLine().ToLower();
   if (userCommand != "end")
      CountPositiveNumbers(Convert.ToInt32(userCommand), step);
   else Console.WriteLine($"You entered {step} positive numbers.");
}

Console.WriteLine($"Enter the numbers one by one and I'll show you how many of them are greater than zero. ");
Console.Write($"Enter the number (to exit enter 'End'): ");
var userCommand = Console.ReadLine().ToLower();
if (userCommand == "end")
   Console.WriteLine($"You have not entered any positive numbers. Try again. ");
else
{
   int count = 0;
   CountPositiveNumbers(Convert.ToInt32(userCommand), count);
}
Console.WriteLine();

*/
// ==== Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1

int CheckNaturalNum(int number)
{
   while (number <= 0)
   {
      Console.Write($"The number of rows or columns in the array cannot be less than one. \nEnter a natural number: ");
      number = Convert.ToInt32(Console.ReadLine());
   }
   return number;
}

void Frame(int row, int columns)
{
   if (row < 3 || columns < 3)
   {
      Console.WriteLine($"That's no way to get a picture. Enter more rows and columns. ");
      Console.Write($"Enter the number of rows of the array: ");
      int userRow = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
      Console.Write($"Enter the number of columns of the array: ");
      int userColumns = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
      Frame(userRow, userColumns);
   }
   else
   {
      int[,] array = new int[row, columns];
      for (int i = 0; i < array.GetLength(0); i++)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            if (i == 0 || j == 0 || i == array.GetLength(0) - 1 || j == array.GetLength(1) - 1)
               array[i, j] = 1;
            else
               array[i, j] = 0;
            Console.Write($"{array[i, j]}");
         }
         Console.WriteLine();
      }
   }
}

Console.Write($"Enter the number of rows of the array: ");
int userRow = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
Console.Write($"Enter the number of columns of the array: ");
int userColumns = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
Frame(userRow, userColumns);