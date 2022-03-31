// по всем задачам создать только войдовские методы, решающие эту задачу, вводить и выводить данные не нужно (остановился на 29:28)

// ==== Задача 1. Задайте двумерный массив размером m×n, заполненный случайными двухзначными целыми числами.

void FillRandomArray(int row, int columns)
{
   int[,] array = new int[row, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = new Random().Next(10, 100);
         Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
   }
}

// ==== Задача 2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

void FillElementProductArray(int row, int columns)
{
   int[,] array = new int[row, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = i * j;
         Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
   }
}

// ==== Задача 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные (ноль считаем четным), и замените эти элементы на их квадраты.

void SqrEvenIndexArray(int row, int columns)
{
   int[,] array = new int[row, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = new Random().Next(1, 10);
         Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
   }
   Console.WriteLine("*****");

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (i % 2 == 0 && j % 2 == 0)
            array[i, j] = array[i, j] * array[i, j];
         Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
   }
}

// ==== Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. Массив при этом должен быть квадратным

void SumDiagonalIndexArray(int row, int columns)
{
   int[,] array = new int[row, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = new Random().Next(1, 10);
         Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
   }
   Console.WriteLine("*****");

   int sum = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (i == j)
            sum += array[i, j];
      }
   }
   Console.WriteLine(sum);
}