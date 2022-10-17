// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] newArray = getArray (4, -100, 100);
printArray(newArray);
Console.Write(" -> ");
int sum = getSum(newArray);
Console.Write (sum);



////////////////////////////////////////////////
int [] getArray(int size, int min, int max)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

static void printArray(int[] newArray)
{
    Console.Write("[");
    for (int i = 0; i < newArray.Length - 1; i++)
        Console.Write($"{newArray[i]}, ");
    Console.Write($"{newArray[newArray.Length - 1]}]");
}

int getSum(int[] newArray)
{
    int sum = 0;
    for (int i = 0; i < newArray.Length; i = i+2)
    {
        sum = sum + newArray[i];
    }
    return sum;
}







































/*Console.Clear();
int[] Array = GetArray(4, -10, 10);
PrintArray(Array);
Console.WriteLine($" -> ");
GetSum(Array);



///////////////////////////////////////////////////////////////   
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] newarray = new int [size];
    for (int i = 0; 1 < size; i++)
    {
         newarray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newarray;
}    
     

void GetSum (int[] Array)
{
    int sum = 0;
    for (int i = 1; i < Array.Length; i = i+2)
    {
        sum = sum + Array [i];
    }
}

void PrintArray (int[] Array)
{
    {
    for (int i = 0; i < Array.Length; i++)
      Console.Write ($"Array[i], ");
    }
    
}
 
*/