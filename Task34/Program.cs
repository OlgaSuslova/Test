// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] newArray = getArray (4, 100, 1000);
printArray(newArray);
Console.Write(" -> ");
int quan = getQuantity(newArray);
Console.Write (quan);



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

int getQuantity(int[] newArray)
{
    int quantity = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i]%2 == 0)
        quantity = quantity + 1;
    }
    return quantity;
}