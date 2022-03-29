// ==== Задача 1. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины. A < B + C

// void CheckTriangle(int number1, int number2, int number3)
// {
//    if (number1 < (number2 + number3) && number2 < (number1 + number3) && number3 < (number1 + number2))
//       Console.WriteLine($"With these sides you get a triangle. ");
//    else Console.WriteLine($"There can be no such triangle. ");
// }

// Console.Write($"Enter the length of the first side of the triangle: ");
// int numUs1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Enter the length of the second side of the triangle: ");
// int numUs2 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Enter the length of the third side of the triangle: ");
// int numUs3 = Convert.ToInt32(Console.ReadLine());

// CheckTriangle(number1: numUs1, number2: numUs2, number3: numUs3);


// ==== Задача 2. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// void BinaryNumber(int number)
// {
//    int count = 0;
//    int newNum = number;
//    while (newNum > 0)
//    {
//       newNum /= 2;
//       count++;
//    }
//    int[] binary = new int[count];
//    for (int i = 0; i < binary.Length; i++)
//    {
//       binary[binary.Length - 1 - i] = number % 2;
//       number /= 2;
//    }
//    for (int a = 0; a < binary.Length; a++)
//    {
//       Console.Write($"{binary[a]}");
//    }
// }

// Console.Write($"Enter the number you want to convert to binary: ");
// int numUs = Convert.ToInt32(Console.ReadLine());
// Console.Write($"The number {numUs} in binary is ");
// BinaryNumber(numUs);
// Console.WriteLine();


// ==== Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// void Fibonacci(int number)
// {
//    int[] result = new int[number];
//    result[1] = 1;
//    for (int i = 2; i < result.Length; i++)
//    {
//       result[i] = result[i - 1] + result[i - 2];
//    }
//    Console.Write($"Fibonacci sequence for {number}: ");
//    for (int a = 0; a < result.Length; a++)
//    {
//       Console.Write($"{result[a]} ");
//    }
// }

// Console.Write($"Enter the number of elements of the Fibonacci numerical sequence: ");
// int numUs = Convert.ToInt32(Console.ReadLine());
// Fibonacci(numUs);
// Console.WriteLine();


// ==== Задача 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void FillRandomArray(int[] arg)
{
   for (int i = 0; i < arg.Length; i++)
      arg[i] = new Random().Next(1, 9);
}

void CopyArray(int[] userArray)
{
   int[,] newArray = new int[2, userArray.Length];
   for (int a = 0; a < newArray.GetLength(0); a++)
   {
      for (int b = 0; b < newArray.GetLength(1); b++)
      {
         newArray[a, b] = userArray[b];
         Console.Write($"{newArray[a, b]} ");
      }
      Console.WriteLine();
   }
}

int[] array = new int[10];
FillRandomArray(array);
CopyArray(array);