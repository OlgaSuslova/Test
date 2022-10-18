// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] newArray = getArray (4, 0, 100);
printArray(newArray);
double min = findMin(newArray);
double max = findMax(newArray);
double dif = max - min;
dif = Math.Round(dif, 2);
Console.Write($" -> {dif}");


////////////////////////////////////////////////
double [] getArray(int size, int min, int max)
{
    double[] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1) + Math.Round(new Random().NextDouble(), 2);
    }
    return array;
}

static void printArray(double[] newArray)
{
    Console.Write("[");
    for (int i = 0; i < newArray.Length - 1; i++)
        Console.Write($"{newArray[i]}, ");
    Console.Write($"{newArray[newArray.Length - 1]}]");
}

double findMin(double[] newArray)
{
    double Min = newArray[0];

    foreach (double element in newArray)
        if (element < Min)
            Min = element;
    return Min;
}

double findMax(double[] newArray)
{
    double Max = newArray[0];

    foreach (double element in newArray)
        if (element > Max)
            Max = element;
    return Max;  
}
