// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int[] userArray = new int[0];
userArray = FillArray(userArray);
int count = CountPositive(userArray);

Console.Write(String.Join(", ", userArray));
Console.Write($" -> {count}");


//////////////////////////////////////////////////////
int[] FillArray(int[] array)
{
    int index = 0;
    Console.WriteLine("Введите элементы массива, для завершения нажмите Q: ");

    while (true)
    {
        string userArrayData = Console.ReadLine() ?? "";
        if (int.TryParse(userArrayData, out int userData))
        {
            Array.Resize(ref array, index + 1);
            array[index] = userData;
            index++;
        }
        else
        {
            userArrayData = userArrayData.ToLower();
            if (userArrayData == "q")
                return array;
            else
                Console.WriteLine("Error");
        }
    }
}

static int CountPositive(int[] array)
{
    int sum = 0;
    foreach (int element in array)
    {
        if (element > 0)
            sum++;
    }
    return sum;
}




