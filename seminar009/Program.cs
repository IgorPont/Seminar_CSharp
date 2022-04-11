// ==== Задача 1. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PointIntersectLine()
{
   double x, y, k1, b1, k2, b2;

   Console.Write($"Enter the value of 'k' for the first equation of the line: ");
   k1 = Convert.ToDouble(Console.ReadLine());
   Console.Write($"Enter the value of 'b' for the first equation of the line: ");
   b1 = Convert.ToDouble(Console.ReadLine());
   Console.Write($"Enter the value of 'k' for the second equation of the line: ");
   k2 = Convert.ToDouble(Console.ReadLine());
   Console.Write($"Enter the value of 'b' for the second equation of the line: ");
   b2 = Convert.ToDouble(Console.ReadLine());

   x = (b2 - b1) / (k1 - k2);
   y = k1 * x + b1;

   Console.Write($"Coordinates of the intersection point of the two lines: ({Math.Round(x, 1)},  {Math.Round(y, 1)}).");
   Console.WriteLine();
}

// PointIntersectLine();

// ==== Задача 2. Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.

int[,] CreateTriangle(int size)
{
   int[,] triangle = new int[size, size];
   for (int i = 0; i < size; i++)
   {
      triangle[i, 0] = 1;
      triangle[i, i] = 1;
   }

   for (int i = 2; i < size; i++)
   {
      for (int j = 1; j < i; j++)
      {
         triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
      }
   }
   return triangle;
}

void PrintTriangle(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int k = 0; k < array.GetLength(0) - i; k++)
         Console.Write($" ");
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (array[i, j] == 0)
            continue;
         else
            Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
   }
   Console.WriteLine();
}

Console.Write($"Enter the size of the Pascal triangle: ");
int sizeTriangle = Convert.ToInt32(Console.ReadLine());
PrintTriangle(CreateTriangle(sizeTriangle));