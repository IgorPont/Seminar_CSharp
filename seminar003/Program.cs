// Задача 1. Написать программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

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