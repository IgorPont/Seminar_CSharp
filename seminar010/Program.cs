// ==== Зазача 1. Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.

// int SumPreviousTwo(int startNum1, int startNum2, int size)
// {
//    if (size == 1) return startNum1;
//    if (size == 2) return startNum2;
//    else return SumPreviousTwo(startNum1, startNum2, size - 1) + SumPreviousTwo(startNum1, startNum2, size - 2);
// }

// for (int i = 1; i <= 10; i++)
// {
//    Console.Write(SumPreviousTwo(0, 1, i) + " ");
// }


// ==== Задача 2. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

// void PrintWords(string alphabet, int lengthWord, string currentWord)
// {
//    if (lengthWord == 0) Console.WriteLine(currentWord);
//    else
//    {
//       for (int i = 0; i < alphabet.Length; i++)
//       {
//          PrintWords(alphabet, lengthWord - 1, currentWord + alphabet[i]);
//       }
//    }
// }
// PrintWords("abc", 3, "");


// ==== Задача 3. Задача: Заданы 2 массива: info и data. В массиве data хранятся двоичные представления нескольких чисел (без разделителя). В массиве info хранится информация о количестве бит, которые занимают числа из массива data. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1


int[] ConvertBinaryDecimal(int[] arrayData, int[] arrayInfo) // метод переводит десятичные представления чисел массива data с учётом информации из массива info
{
   int indexArrayInfo = 0;
   int indexArrayData = 0;
   int[] result = new int[arrayInfo.Length];

   while (indexArrayInfo < arrayInfo.Length)
   {
      int[] array = new int[arrayInfo[indexArrayInfo]];

      for (int i = 0; i < array.Length; i++)
      {
         array[i] = arrayData[indexArrayData];
         indexArrayData++;
      }

      for (int i = 0; i < array.Length; i++)
      {
         result[indexArrayInfo] += array[i] * (int)Math.Pow(2, array.Length - 1 - i);
      }
      indexArrayInfo++;
   }
   return result;
}

int CheckBinaryNum(int number) // метод проверят значения, которые вводит пользователь, являются ли они двоичными, если нет, то запрашивает снова
{
   while (number < -1 || number > 1)
   {
      Console.WriteLine($"You entered a number in a non-binary representation. \nEnter 0 or 1: ");
      number = Convert.ToInt32(Console.ReadLine());
   }
   return number;
}

int[] FillArrayBinaryNum() // метод заполняет массив data двоичными числами
{
   int item = 1;
   int[] binaryArray = new int[item];

   Console.WriteLine($"Enter binary representations of numbers using 0 or 1. \nType -1 to end the input. ");
   int numUser = CheckBinaryNum(Convert.ToInt32(Console.ReadLine()));
   if (numUser == -1)
   {
      Console.WriteLine($"You didn't enter any numbers. Try again. ");
      numUser = CheckBinaryNum(Convert.ToInt32(Console.ReadLine()));
   }

   while (numUser != -1)
   {
      binaryArray[item - 1] = numUser;
      numUser = CheckBinaryNum(Convert.ToInt32(Console.ReadLine()));
      if (numUser == -1) break;
      Array.Resize(ref binaryArray, binaryArray.Length + 1);
      item++;
   }
   return binaryArray;
}

int CheckNaturalNum(int number) // метод проверяет числа, которые пользователь вводит, заполняя массим info, на натуральные
{
   while (number <= 0 && number != -1)
   {
      Console.WriteLine($"Enter a natural number. ");
      number = Convert.ToInt32(Console.ReadLine());
   }
   return number;
}

int[] FillArrayBitsNum() // метод заполняет массив info натуральными числами
{
   int item = 1;
   int[] bitsArray = new int[item];

   Console.WriteLine($"Enter the numbers corresponding to the number of bits that binary numbers occupy. \nType -1 to end the input. ");
   int numUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
   if (numUser == -1)
   {
      Console.WriteLine($"You didn't enter any numbers. Try again. ");
      numUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
   }

   while (numUser != -1)
   {
      bitsArray[item - 1] = numUser;
      numUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
      if (numUser == -1) break;
      Array.Resize(ref bitsArray, bitsArray.Length + 1);
      item++;
   }
   return bitsArray;
}

int[] DiffBinBitsArray(int[] binArr, int[] bitsArr) // метод увеличивает массив data, если пользователь ввел больше значений в массив info
{
   int sumBitItem = 0;
   for (int i = 0; i < bitsArr.Length; i++)
   {
      sumBitItem += bitsArr[i];
   }

   if (binArr.Length < sumBitItem)
   {
      int diffBinBits = sumBitItem - binArr.Length;
      Array.Resize(ref binArr, binArr.Length + diffBinBits);
      return binArr;
   }
   else return binArr;
}

int[] CheckBitsArray(int[] binArr, int[] bitsArr) // метод увеличивает массив info, если пользователь ввел больше значений в массив data 
{
   int sumBitItem = 0;
   for (int i = 0; i < bitsArr.Length; i++)
   {
      sumBitItem += bitsArr[i];
   }

   if (binArr.Length > sumBitItem)
   {
      int diffBinBits = binArr.Length - sumBitItem;
      Array.Resize(ref bitsArr, bitsArr.Length + 1);
      bitsArr[bitsArr.Length - 1] = diffBinBits;
      return bitsArr;
   }
   else return bitsArr;
}

void PrintArray(int[] array) // метод выводит эелементы массива в консоле
{
   Console.Write($"[ ");
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]}");
      if (i == array.Length - 1) break;
      Console.Write($", ");
   }
   Console.Write($" ]");
   Console.WriteLine();
}


// решение с фиксированными значениями data и info из примера к задаче

// int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
// int[] info = { 2, 3, 3, 1 };
// PrintArray(ConvertBinaryDecimal(data, info));

// решение, когда пользователь сам вводит элементы data и info

int[] data = FillArrayBinaryNum();
int[] info = FillArrayBitsNum();
data = DiffBinBitsArray(data, info);
info = CheckBitsArray(data, info);

PrintArray(ConvertBinaryDecimal(data, info));


