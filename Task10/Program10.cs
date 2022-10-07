int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write ("Введите трехзначное число: ");
        if (int.TryParse (Console.ReadLine(), out number))
           if (99 < number && number < 1000)
           break;
        Console.WriteLine ($"Ошибка ввода!");   
    }
    return number;
}

int a1 = EnterNumber();
int a2 = a1 / 10;
int a3 = a2 % 10;

Console.WriteLine ($"{a1} -> {a3}");
