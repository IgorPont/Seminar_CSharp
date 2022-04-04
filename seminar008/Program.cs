// Ниже представлены методы, которые я использую при решении задач

int[,] FillRandomArray(int row, int column)
{
   int[,] array = new int[row, column];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
         array[i, j] = new Random().Next(10, 100);
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

int[,] CheckRowsArray(int[,] array)
{
   int temp;
   for (int i = 0; i < array.GetLength(1); i++)
   {
      temp = array[0, i];
      array[0, i] = array[array.GetLength(0) - 1, i];
      array[array.GetLength(0) - 1, i] = temp;
   }
   return array;
}

int[,] ReplaceColumnOnRowArray(int[,] array)
{
   if (array.GetLength(0) == array.GetLength(1))
   {
      int temp;
      for (int i = 0; i < array.GetLength(0); i++)
      {
         for (int j = i; j < array.GetLength(1); j++)
         {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
         }
      }
      return array;
   }
   else Console.WriteLine($"It is not possible to flip the array. ");
   return array;
}

void DeleteRowColumnMinElemArray(int[,] array)
{
   int min = array[0, 0];
   int minI = 0;
   int minJ = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (array[i, j] < min)
         {
            min = array[i, j];
            minI = i;
            minJ = j;
         }
      }
   }

   for (int i = 0; i < array.GetLength(0); i++)
   {
      if (i == minI)
         continue;

      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (j == minJ)
            continue;
         Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
   }


   // for (int i = 0; i < array.GetLength(0); i++) // заменяет строку и столбец на 11 и возвращает массив
   //    array[i, minJ] = 11;

   // for (int j = 0; j < array.GetLength(1); j++)
   //    array[minI, j] = 11;

   // return array;
}

// Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[,] userArray = FillRandomArray(4, 5);
// PrintArray(userArray);
// PrintArray(CheckRowsArray(userArray));


// Задача 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] userArray = FillRandomArray(5, 5);
// PrintArray(userArray);
// PrintArray(ReplaceColumnOnRowArray(userArray));


// Задача 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] userArray = FillRandomArray(5, 5);
PrintArray(userArray);
DeleteRowColumnMinElemArray(userArray);
