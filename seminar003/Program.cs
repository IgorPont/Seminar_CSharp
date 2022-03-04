// Задача 1. Написать программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int GetQuart(double xPoint, double yPoint)
{
   if (xPoint > 0 && yPoint > 0) return 1;
   if (xPoint < 0 && yPoint > 0) return 2;
   if (xPoint < 0 && yPoint < 0) return 3;
   if (xPoint > 0 && yPoint < 0) return 4;
   return 0; // if (xPoint == 0 || yPoint == 0) 
}

double x, y;
int quartNum;
Console.Write("Input X: ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y: ");
y = Convert.ToDouble(Console.ReadLine());

quartNum = GetQuart(x, y);
if (quartNum == 0) Console.WriteLine("Нельзя определить четверть ");
else Console.WriteLine("Данная точка находится в " + quartNum + " четверти. ");

// Задача 2. Написать программу, которая принимает на вход номер четверти и выводит на экран диапазон координат, доступных в этой четверти

void quarterNumber(int num)
{
   switch (num)
   {
      case 1:
         Console.WriteLine("В I четверти диапазон координа Х > 0, Y > 0");
         break;

      case 2:
         Console.WriteLine("В II четверти диапазон координа Х < 0, Y > 0");
         break;

      case 3:
         Console.WriteLine("В III четверти диапазон координа Х < 0, Y < 0");
         break;

      case 4:
         Console.WriteLine("В IV четверти диапазон координа Х > 0, Y < 0");
         break;

      default:
         Console.WriteLine("Такой четверти не существует. Попробуйте еще раз, введите номер четверти от 1 до 4.");
         break;
   }
}

Console.Write("Чтобы узнать диапазон координат, доступных в конкретной четверти, введите номер четверти координатной плоскости: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
quarterNumber(userNumber);
*/

// Задача 3. Написать программу, принимающую на вход координаты двух точек и определяющую расстояние между ними

double pointDistance(double xANum, double yANum, double xBNum, double yBNum)
{
   double ACDistance = xBNum - xANum;
   double BCDistance = yBNum - yANum;
   double pDist = Math.Sqrt(Math.Pow(ACDistance, 2) + Math.Pow(BCDistance, 2));
   return pDist;
}

Console.WriteLine("Введите координаты двух точек, чтобы узнать расстояние между ними в декартовой системе координат. ");
Console.WriteLine("Координаты первой точки (xA, yA): ");
double xA = Convert.ToInt32(Console.ReadLine());
double yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты второй точки (xB, yB): ");
double xB = Convert.ToInt32(Console.ReadLine());
double yB = Convert.ToInt32(Console.ReadLine());

if (xA == 0 && yA == 0 && xB == 0 && yB == 0)
   Console.WriteLine("Расстояние между двумя точками равно нулю. ");

double result = pointDistance(xA, yA, xB, yB);
Console.WriteLine("Расстояние между двумя точками равно: " + result);