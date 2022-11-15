/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();
int[,] array = FillArray(4, 4);
PrintArray(array);


////////////////////////
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    int i = 0;
    int j = 0;
    array[i, j] = 1;

    while (true)
    {
        while (j + 1 < column && array[i, j + 1] == 0)
        {
            array[i, j + 1] = array[i, j] + 1;
            j += 1;
        }
        while (i + 1 < row && array[i + 1, j] == 0)
        {
            array[i + 1, j] = array[i, j] + 1;
            i += 1;
        }
        while (j > 0 && array[i, j - 1] == 0)
        {
            array[i, j - 1] = array[i, j] + 1;
            j -= 1;
        }
        while (i > 0 && array[i - 1, j] == 0)
        {
            array[i - 1, j] = array[i, j] + 1;
            i -= 1;
        }
        if (array[i, j] == row * column)
            break;
    }
    return array;
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