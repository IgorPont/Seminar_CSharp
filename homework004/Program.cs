// ==== Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵); 2, 4 -> 16

double NumberDegree(int num, int deg) // учтены все варианты (0^n; n^0; -n^n; n^-n; -n^-n)
{
   if (num != 0)
   {
      int result = 1;
      for (int i = 0; i < Math.Abs(deg); i++)
      {
         result *= num;
      }
      if (deg >= 0)
      {
         return result;
      }
      else
      {
         double div = 1.0 / result;
         return div;
      }
   }
   else return 0;
}

Console.Write("Enter the number you want to raise to the natural degree: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the natural degree to which you want to put the number: ");
int degreeUser = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The number {numberUser} to the power of {degreeUser} is {NumberDegree(num: numberUser, deg: degreeUser)}.");
Console.WriteLine();


// ==== Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11; 82 -> 10; 9012 -> 12



// ==== Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]
