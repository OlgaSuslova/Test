// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
Console.WriteLine($"Двумерный массив случайных чисел:"); 

int[,] array = GetArray(4, 4, 0, 9);
PrintArray(array);
int[] result = FindRowNumber(array);
Console.WriteLine($"Строка с наименьшей суммой - {result[0]}");


/////////////////////////
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[] FindRowNumber (int [,] array)
{   int[] result = new int[2];
    result[1] = array[0, 0];

    for (int j = 1; j < array.GetLength(1); j++)
      {
        result[1] = result[1] + array[0,j];
      }

      for (int i = 1; i < array.GetLength(0); i++)
      {
        int sum = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
          sum = sum + array[i,j];
        }
        if (sum < result[1])
        {
          result[1] = sum;
          result[0] = i + 1;
        }
      }
      return result;
    }
           

