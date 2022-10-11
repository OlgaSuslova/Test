//Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27.
//5 -> 1, 8, 27, 64, 125.

static void PrintCube(int N)
{
    for (int i = 1; i < N; i++)
    {
        Console.Write($"{i * i * i}, ");
    }
}

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");

Console.Write($"{number} -> ");
PrintCube(number);
Console.WriteLine($"{number*number*number}.");