// ==== Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

void CountPositiveNumbers(int command, int step)
{
   if (command > 0)
      step++;
   Console.Write($"Enter the number (to exit enter 'End'): ");
   var userCommand = Console.ReadLine().ToLower();
   if (userCommand != "end")
      CountPositiveNumbers(Convert.ToInt32(userCommand), step);
   else Console.WriteLine($"You entered {step} positive numbers.");
}

Console.WriteLine($"Enter the numbers one by one and I'll show you how many of them are greater than zero. ");
Console.Write($"Enter the number (to exit enter 'End'): ");
var userCommand = Console.ReadLine().ToLower();
if (userCommand == "end")
   Console.WriteLine($"You have not entered any positive numbers. Try again. ");
else
{
   int count = 0;
   CountPositiveNumbers(Convert.ToInt32(userCommand), count);
}
Console.WriteLine();







// ==== Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1