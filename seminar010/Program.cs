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


// ==== Задача 3. Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1


int[] ConvertBinaryDecimal(int[] arrayData, int[] arrayInfo)
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

void PrintArray(int[] array)
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

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
PrintArray(ConvertBinaryDecimal(data, info));

