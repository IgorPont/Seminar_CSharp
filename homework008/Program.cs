// Ниже представлены методы, которые используются при решении задач. Сами решения - после описания задачи.

int CheckNaturalNum(int number)
{
   while (number <= 0)
   {
      Console.Write($"The number of rows or columns in the array must be natural. \nEnter a natural number: ");
      number = Convert.ToInt32(Console.ReadLine());
   }
   return number;
}

int HitCheckNum(int[,,] array, int num)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int k = 0; k < array.GetLength(2); k++)
         {
            if (array[i, j, k] == num)
            {
               num = new Random().Next(10, 100);
               HitCheckNum(array, num);
            }
         }
      }
   }
   return num;
}

int[,] CreateFillRandomArray()
{
   Console.Write($"Enter the number of rows of a two-dimensional array: ");
   int rowUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
   Console.Write($"Enter the number of columns of a two-dimensional array: ");
   int columnUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

   int[,] array = new int[rowUser, columnUser];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
         array[i, j] = new Random().Next(1, 10);
   }
   return array;
}

int[,,] CreateFillRandomThreeDimArray()
{
   Console.Write($"Enter the number of rows of a two-dimensional array: ");
   int row = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
   Console.Write($"Enter the number of columns of a two-dimensional array: ");
   int column = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
   Console.Write($"Enter the number of layers of a two-dimensional array: ");
   int layer = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

   int[,,] array = new int[row, column, layer];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int k = 0; k < array.GetLength(2); k++)
            array[i, j, k] = HitCheckNum(array, new Random().Next(10, 100));
      }
   }
   return array;
}

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
         Console.Write($"{array[i, j]} ");
      Console.WriteLine();
   }
   Console.WriteLine();
}

void PrintThreeDimArray(int[,,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int k = 0; k < array.GetLength(2); k++)
            Console.Write($"{array[i, j, k]} ");
         Console.WriteLine();
      }
      Console.WriteLine();
   }
}

void PrintThreeDimIndexArray(int[,,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int k = 0; k < array.GetLength(2); k++)
            Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
         Console.WriteLine();
      }
      Console.WriteLine();
   }
}

int[,] SortElementRowArray(int[,] array)
{
   int temp;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int m = j + 1; m < array.GetLength(1); m++)
         {
            if (array[i, j] > array[i, m])
            {
               temp = array[i, j];
               array[i, j] = array[i, m];
               array[i, m] = temp;
            }
         }
      }
   }
   return array;
}

int MinSumRowArray(int[,] array)
{
   int sumRow = 0;
   for (int j = 0; j < array.GetLength(1); j++)
      sumRow += array[0, j];
   int minSumRow = sumRow;
   int numberRow = 1;
   // Console.WriteLine($"{minSumRow} / {numberRow}"); // для проверки

   for (int i = 1; i < array.GetLength(0); i++)
   {
      sumRow = 0;
      for (int j = 0; j < array.GetLength(1); j++)
         sumRow += array[i, j];

      if (sumRow < minSumRow)
      {
         minSumRow = sumRow;
         numberRow = i + 1;
      }
      // Console.WriteLine($"{sumRow} / {numberRow}"); // для проверки
   }
   return numberRow;
}

int[,] FillSpiralArray()
{
   Console.Write($"Enter the number of matrix rows: ");
   int numRow = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
   Console.Write($"Enter the number of matrix columns: ");
   int numColumn = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

   int[,] array = new int[numRow, numColumn];
   int num = 1;
   int count = 0;

   do
   {
      int i = count;
      while (i < array.GetLength(1) - count)
      {
         if (num > numRow * numColumn)
            break;
         else
         {
            array[i - i + count, i] = num;
            num++;
            i++;
         }
      }

      i = count + 1;
      while (i < array.GetLength(0) - count)
      {
         if (num > numRow * numColumn)
            break;
         else
         {
            array[i, array.GetLength(1) - 1 - count] = num;
            num++;
            i++;
         }
      }

      i = count;
      while (i < array.GetLength(1) - 1 - count)
      {
         if (num > numRow * numColumn)
            break;
         else
         {
            array[array.GetLength(0) - 1 - count, array.GetLength(1) - 2 - i] = num;
            num++;
            i++;
         }
      }

      i = count;
      while (i < array.GetLength(0) - 2 - count)
      {
         if (num > numRow * numColumn)
            break;
         else
         {
            array[array.GetLength(0) - 2 - i, i - i + count] = num;
            num++;
            i++;
         }
      }
      count++;
   }
   while (num <= numRow * numColumn);
   return array;
}

// ==== Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] userArray = CreateFillRandomArray();
// PrintArray(userArray);
// PrintArray(SortElementRowArray(userArray));


// ==== Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] userArray = CreateFillRandomArray();
// PrintArray(userArray);
// Console.WriteLine($"The smallest sum of elements in row {MinSumRowArray(userArray)} of the array. ");


// ==== Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// PrintThreeDimIndexArray(CreateFillRandomThreeDimArray());


// ==== Задача 4: Заполните спирально массив 4 на 4.
// На выходе получается вот такой массив:


PrintArray(FillSpiralArray()); // заполняет спирально массив любого размера, как квадратный, так и прямоугольный