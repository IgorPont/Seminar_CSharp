// ==== Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int CheckNaturalNum(int number)
{
   while (number <= 0)
   {
      Console.Write($"The number of rows or columns in the array must be natural. \nEnter a natural number: ");
      number = Convert.ToInt32(Console.ReadLine());
   }
   return number;
}

void PrintDoubleArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
   }
}

void PrintIntArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
   }
}

double[,] FillRandomDoubleArray(int row, int columns)
{
   Console.Write($"Enter the beginning of the random number range: ");
   int startNum = Convert.ToInt32(Console.ReadLine());
   Console.Write($"Enter the end of the random number range: ");
   int endNum = Convert.ToInt32(Console.ReadLine());

   double[,] array = new double[row, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
         array[i, j] = Math.Round(new Random().Next(startNum, endNum + 1) + new Random().NextDouble(), 1);
   }
   return array;
}

int[,] FillRandomIntArray(int row, int columns)
{
   Console.Write($"Enter the beginning of the random number range: ");
   int startNum = Convert.ToInt32(Console.ReadLine());
   Console.Write($"Enter the end of the random number range: ");
   int endNum = Convert.ToInt32(Console.ReadLine());

   int[,] array = new int[row, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
         array[i, j] = new Random().Next(startNum, endNum + 1);
   }
   return array;
}

void CheckElementArray(int[,] array, int rowNum, int columnNum)
{
   if (rowNum > array.GetLength(0) || columnNum > array.GetLength(1))
      Console.WriteLine($"This element is not in the array. ");
   else
      Console.WriteLine($"The element you are looking for is {array[rowNum - 1, columnNum - 1]}. ");
}

void ArithMeanColumnsArray(int[,] array)
{
   double[] arithMean = new double[array.GetLength(1)];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
         arithMean[j] += array[i, j];
   }

   for (int m = 0; m < arithMean.Length; m++)
   {
      arithMean[m] /= array.GetLength(0);
      Console.WriteLine($"The arithmetic mean of the numbers in the column {m + 1} is {Math.Round(arithMean[m], 1)} ");
   }
   Console.WriteLine();
}


// Console.Write($"Enter the number of rows of a two-dimensional array: ");
// int rowsUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
// Console.Write($"Enter the number of columns of a two-dimensional array: ");
// int columnsUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

// PrintDoubleArray(FillRandomDoubleArray(rowsUser, columnsUser));


// ==== Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

// Console.Write($"Enter the number of rows of a two-dimensional array: ");
// int rowsUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
// Console.Write($"Enter the number of columns of a two-dimensional array: ");
// int columnsUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

// int[,] arrayUser = FillRandomIntArray(rowsUser, columnsUser);
// PrintIntArray(arrayUser);
// Console.WriteLine();

// Console.WriteLine($"Enter the position of an element in a two-dimensional array \nin the format: row number and column number. ");
// Console.Write($"Row number: ");
// int rowNumber = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
// Console.Write($"Column number: ");
// int columnNumber = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine();

// CheckElementArray(arrayUser, rowNumber, columnNumber);
// Console.WriteLine();

// ==== Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write($"Enter the number of rows of a two-dimensional array: ");
int rowsUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
Console.Write($"Enter the number of columns of a two-dimensional array: ");
int columnsUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

int[,] arrayUser = FillRandomIntArray(rowsUser, columnsUser);
PrintIntArray(arrayUser);
Console.WriteLine();

ArithMeanColumnsArray(arrayUser);