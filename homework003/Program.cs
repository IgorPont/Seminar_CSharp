// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int InvertNumber(int number)
{
   int n5 = number % 10;
   int n4 = (number / 10) % 10;
   int n3 = (number / 100) % 10;
   int n2 = (number / 1000) % 10;
   int n1 = number / 10000;
   int invNum = (n5 * 10000) + (n4 * 1000) + (n3 * 100) + (n2 * 10) + n1;
   return invNum;
}

Console.Write("Введи пятизначное число и проверь, является ли оно палиндромом: ");
int numberUser = Convert.ToInt32(Console.ReadLine());

if (numberUser >= 10000 && numberUser <= 99999)
{
   int newNum = InvertNumber(numberUser);
   if (newNum == numberUser)
   {
      Console.WriteLine("Введенное Вами число является палиндромом. ");
   }
   else
   {
      Console.WriteLine("Это не число-палиндром. Попробуйте еще раз. ");
   }
}
else
{
   Console.WriteLine("Вы ввели не пятизначное число. Попробуйте еще раз. ");
}

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DistancePoint(double xANum, double yANum, double zANum, double xBNum, double yBNUm, double zBNum)
{
   double xDistance = xBNum - xANum;
   double yDistance = yBNUm - yANum;
   double zDistance = zBNum - zANum;

   double result = Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
   return result;
}

Console.WriteLine("Введи координаты двух точек и узнаешь расстояние между ними в трехмерном пространстве. ");
Console.WriteLine("Введи координаты первой точки в формате (Xa, Ya, Za): ");
double XaPoint = Convert.ToInt32(Console.ReadLine());
double YaPoint = Convert.ToInt32(Console.ReadLine());
double ZaPoint = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи координаты второй точки в формате (Xb, Yb, Zb): ");
double XbPoint = Convert.ToInt32(Console.ReadLine());
double YbPoint = Convert.ToInt32(Console.ReadLine());
double ZbPoint = Convert.ToInt32(Console.ReadLine());

double UserDistansePoint = DistancePoint(XaPoint, YaPoint, ZaPoint, XbPoint, YbPoint, ZbPoint);
Console.WriteLine("Расстояние между двумя точками равно: " + UserDistansePoint);
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cubeTable(double number)
{
   int count = 1;
   while (count <= number)
   {
      double newNumber = Math.Pow(count, 3);
      Console.Write(newNumber + ", ");
      count++;
   }

}

Console.Write("Введите число, чтобы получить результ вовзведения в тертью степень чисел от 1 до введенного числа: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов от 1 " + "до " + userNumber + ": ");
cubeTable(userNumber);
