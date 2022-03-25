// Ниже представлены методы, которые я использую при решении всех четырех задач

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

void PrintSumPosNegArray(int[] arrayUser)
{
   int sumPos = 0;
   int sumNeg = 0;
   for (int a = 0; a < arrayUser.Length; a++)
   {
      if (arrayUser[a] > 0) sumPos += arrayUser[a];
      else sumNeg += arrayUser[a];
   }
   Console.WriteLine($"The sum of the negative elements of the array is {sumNeg}. The sum of the positive elements of the array is {sumPos}");
}

int[] ChangePosNeg(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] *= -1;
   return array;
}

void PrintCheckNumArray(int[] array, int number)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] == number)
         count++;
      if (count == 1)
         break;
   }
   if (count > 0)
      Console.WriteLine($"The number you entered is present in the array. ");
   else Console.WriteLine($"There is no such number in the array. ");
}

void PrintNumberRangeCheck(int[] array) // диапазон 10...99
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
      if (array[i] > 9 && array[i] < 100)
         count++;
   Console.WriteLine($"In the given range of the array found {count} elements.");
}

int[] MirrProdTwoArrEl(int[] array)
{
   int arrLeng = 0;
   if (array.Length % 2 == 0) arrLeng = array.Length / 2;
   else arrLeng = (array.Length / 2) + 1;

   int[] newArray = new int[arrLeng];
   for (int i = 0; i < newArray.Length; i++)
      newArray[i] = array[i] * array[array.Length - 1 - i];
   newArray[newArray.Length - 1] = array[(array.Length - 1) / 2];
   return newArray;
}

// ==== Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-99, 99]. Найдите сумму отрицательных и положительных элементов массива.

// Console.Write($"Enter the number of elements in the array: ");
// int elementArray = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

// Console.Write($"Enter a range of numbers in the array.");
// Console.Write($"Beginning of range: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write($"End of Range: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// int[] userArray = FillRandomNumArray(new int[elementArray], firstNum, secondNum);
// PrintArray(userArray);
// PrintSumPosNegArray(userArray);


// ==== Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// Console.Write($"Enter the number of elements in the array: ");
// int elementArray = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

// Console.Write($"Enter a range of numbers in the array.");
// Console.Write($"Beginning of range: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write($"End of Range: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// int[] userArray = FillRandomNumArray(new int[elementArray], firstNum, secondNum);

// PrintArray(userArray);
// PrintArray(ChangePosNeg(userArray));


// ==== Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// Console.Write($"Enter the number of elements in the array: ");
// int elementArray = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

// Console.Write($"Enter a range of numbers in the array.");
// Console.Write($"Beginning of range: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write($"End of Range: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// int[] userArray = FillRandomNumArray(new int[elementArray], firstNum, secondNum);

// Console.Write($"Enter the number you want to check in the array: ");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// PrintCheckNumArray(userArray, userNumber);
// PrintArray(userArray);


// ==== Задача 4. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Console.Write($"Enter the number of elements in the array: ");
// int elementArray = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

// Console.Write($"Enter a range of numbers in the array.");
// Console.Write($"Beginning of range: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write($"End of Range: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// int[] userArray = FillRandomNumArray(new int[elementArray], firstNum, secondNum);

// PrintNumberRangeCheck(userArray);


// ==== Задача 5. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.Write($"Enter the number of elements in the array: ");
int elementArray = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));

Console.Write($"Enter a range of numbers in the array. ");
Console.Write($"Beginning of range: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write($"End of Range: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
int[] userArray = FillRandomNumArray(new int[elementArray], firstNum, secondNum);

PrintArray(userArray);
PrintArray(MirrProdTwoArrEl(userArray));