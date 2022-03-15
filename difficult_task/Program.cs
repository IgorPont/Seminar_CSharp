// Задача. Пользователь вводит целые числа до тех пор, пока не введёт ноль. Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел. А теперь самое интересное: создавать массивы в процессе решения запрещено. Например: 5 2 - 3 17 - 5 4 0 / 5 и 17 - макс, -5 и -3 - мин. В случае, если введенных элементов < 2, то нужно это обработать отдельно.

int numberUser = 0;
int min1 = 0; int min2 = 0;
int max1 = 0; int max2 = 0;

Console.Write("Input a number: ");
numberUser = Convert.ToInt32(Console.ReadLine());
min1 = numberUser;

Console.Write("Input a number: ");
numberUser = Convert.ToInt32(Console.ReadLine());
if (numberUser >= min1) min2 = numberUser;
else
{
   min2 = min1;
   min1 = numberUser;
}

Console.Write("Input a number: ");
numberUser = Convert.ToInt32(Console.ReadLine());
if (numberUser < min1)
{
   max1 = min2;
   min2 = min1;
   min1 = numberUser;
}
if (numberUser > min2) max1 = numberUser;
if (numberUser > min1 && numberUser < min2)
{
   max1 = min2;
   min2 = numberUser;
}

Console.Write("Input a number: ");
numberUser = Convert.ToInt32(Console.ReadLine());
if (numberUser < min1)
{
   max2 = max1;
   max1 = min2;
   min2 = min1;
   min1 = numberUser;

}
if (numberUser > min1 && numberUser < min2)
{
   max2 = max1;
   max1 = min2;
   min2 = numberUser;
}
if (numberUser > min2 && numberUser < max1)
{
   max2 = max1;
   max1 = numberUser;
}
if (numberUser > max1) max2 = numberUser;
else
{
   max2 = max1;
   max1 = numberUser;
}

do
{
   Console.Write("Input a number: ");
   numberUser = Convert.ToInt32(Console.ReadLine());

   if (numberUser == 0) break;

   if (numberUser < min1)
   {
      min2 = min1;
      min1 = numberUser;
   }

   if (numberUser > min1 && numberUser < min2) min2 = numberUser;

   if (numberUser > max1 && numberUser < max2) max1 = numberUser;

   if (numberUser > max2)
   {
      max1 = max2;
      max2 = numberUser;
   }
}
while (numberUser != 0);

Console.WriteLine("Первые два максимальных числа: " + max1 + ", " + max2 + ". " + "Первые два минимальных числа: " + min1 + ", " + min2 + ". ");