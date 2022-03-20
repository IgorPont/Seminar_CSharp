// Задача. Пользователь вводит целые числа до тех пор, пока не введёт ноль. Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел. А теперь самое интересное: создавать массивы в процессе решения запрещено. Например: 5 2 - 3 17 - 5 4 0 / 5 и 17 - макс, -5 и -3 - мин. В случае, если введенных элементов < 2, то нужно это обработать отдельно.

Console.Clear();

int numberUser = 0;
int min1 = 0; int min2 = 0;
int max1 = 0; int max2 = 0;
int count = 0;

Console.Write("Enter any number and I'll show you two maximum and two minimum numbers. ");
Console.WriteLine();

do
{
   Console.Write("Input a number: ");
   numberUser = Convert.ToInt32(Console.ReadLine());

   count++;

   if (count == 4 && numberUser == 0)
   {
      Console.WriteLine("The first maximal numbers: " + max1 + ". " + "The first two minimum numbers: " + min1 + ", " + min2 + ". ");
      break;
   }

   if (count == 3 && numberUser == 0)
   {
      Console.WriteLine("The first maximal numbers: " + min2 + ". " + "The first minimum numbers: " + min1 + ". ");
      break;
   }

   if (count == 1 && numberUser == 0 || count == 2 && numberUser == 0)
   {
      Console.WriteLine("Less than two numbers are entered. Try again. ");
      break;
   }

   if (numberUser == 0)
   {
      Console.WriteLine("The first two maximal numbers: " + max1 + ", " + max2 + ". " + "The first two minimum numbers: " + min1 + ", " + min2 + ". ");
      break;
   }

   if (count == 1 && numberUser != 0)
   {
      min1 = numberUser;
      continue;
   }

   if (count == 2 && numberUser >= min1)
   {
      min2 = numberUser;
      continue;
   }

   if (count == 2 && numberUser < min1)
   {
      min2 = min1;
      min1 = numberUser;
      continue;
   }

   if (count == 3 && numberUser <= min1)
   {
      max1 = min2;
      min2 = min1;
      min1 = numberUser;
      continue;
   }

   if (count == 3 && numberUser >= min2)
   {
      max1 = numberUser;
      continue;
   }

   if (count == 3 && numberUser > min1 && numberUser < min2)
   {
      max1 = min2;
      min2 = numberUser;
      continue;
   }

   if (count == 4 && numberUser <= min1)
   {
      max2 = max1;
      max1 = min2;
      min2 = min1;
      min1 = numberUser;
      continue;
   }

   if (count == 4 && numberUser >= max1)
   {
      max2 = numberUser;
      continue;
   }

   if (count == 4 && numberUser > min1 && numberUser < min2)
   {
      max2 = max1;
      max1 = min2;
      min2 = numberUser;
      continue;
   }

   if (count == 4 && numberUser > min2 && numberUser < max1)
   {
      max2 = max1;
      max1 = numberUser;
      continue;
   }

   if (count > 4 && numberUser <= min1)
   {
      min2 = min1;
      min1 = numberUser;
      continue;
   }

   if (count > 4 && numberUser >= max2)
   {
      max1 = max2;
      max2 = numberUser;
      continue;
   }

   if (count > 4 && numberUser > min1 && numberUser < min2)
   {
      min2 = numberUser;
      continue;
   }

   if (count > 4 && numberUser > max1 && numberUser < max2)
   {
      max1 = numberUser;
      continue;
   }

   if (count > 4 && numberUser > min2 && numberUser < max1) continue;

}
while (numberUser != 0);

Console.ReadLine();