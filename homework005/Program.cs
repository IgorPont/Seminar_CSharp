// Ниже представлены методы, которые я использую при решении всех задач, а решение задачи - после описания ее условия.

int[] FillRandomNumArray(int[] array, int startRange, int endRange)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(startRange, endRange + 1);
   return array;
}

int CheckNaturalNum(int number)
{
   while (number <= 0)
   {
      Console.Write($"The number of elements in the array must be natural. Enter a natural number: ");
      number = Convert.ToInt32(Console.ReadLine());
   }
   return number;
}

void PrintArray(int[] array)
{
   Console.WriteLine();
   Console.Write($"[ ");
   for (int p = 0; p < array.Length; p++)
   {
      Console.Write($"{array[p]}");
      if (p == array.Length - 1) break;
      Console.Write($", ");
   }
   Console.WriteLine($" ]");
   Console.WriteLine();
}

int NumEvenNum(int[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
      if (array[i] % 2 == 0)
         count++;
   return count;
}

int SumElemOddIndex(int[] array)
{
   int sum = 0;
   for (int i = 1; i < array.Length; i += 2)
      sum += array[i];
   return sum;
}

int[] MaxMinNum(int[] array)
{
   int min = array[0];
   int max = array[1];
   if (min > max)
   {
      max = array[0];
      min = array[1];
   }
   for (int i = 2; i < array.Length; i++)
   {
      if (array[i] < min)
         min = array[i];
      if (array[i] > max)
         max = array[i];
   }
   int[] newArray = { min, max };
   return newArray;
}

// ==== Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

// Console.Write($"Enter the number of elements in the array: ");
// int elementArray = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

// Console.Write($"Enter a range of numbers in the array. ");
// Console.Write($"Start of range: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write($"End of Range: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// int[] userArray = FillRandomNumArray(new int[elementArray], firstNum, secondNum);

// PrintArray(userArray);
// Console.WriteLine($"The number of even numbers in the array is {NumEvenNum(userArray)}. ");
// Console.WriteLine();


// ==== Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

// Console.Write($"Enter the number of elements in the array: ");
// int elementArray = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

// Console.Write($"Enter a range of numbers in the array. ");
// Console.Write($"Start of range: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write($"End of Range: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// int[] userArray = FillRandomNumArray(new int[elementArray], firstNum, secondNum);

// PrintArray(userArray);
// Console.WriteLine($"The sum of elements at odd positions is {SumElemOddIndex(userArray)}. ");
// Console.WriteLine();


// ==== Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

Console.Write($"Enter the number of elements in the array: ");
int elementArray = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"Enter a range of numbers in the array. ");
Console.Write($"Start of range: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write($"End of Range: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
int[] userArray = FillRandomNumArray(new int[elementArray], firstNum, secondNum);

PrintArray(userArray);
PrintArray(MaxMinNum(userArray));
Console.WriteLine($"The difference between the maximum and the minimum element of the array is {MaxMinNum(userArray)[1] - MaxMinNum(userArray)[0]}");