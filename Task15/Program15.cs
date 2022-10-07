int EnterNumber()
{
int number;
    while (true)
    {
        Console.Write ("Введите днем недели: ");
        if (int.TryParse (Console.ReadLine(), out number))
           break;
        Console.WriteLine ($"Ошибка ввода!");   
    }
    return number;
}

int a = EnterNumber();

if ( a>0 && a<6 )
{
    Console.WriteLine ($"{a} -> нет");
}

else if ( a==6 && a==7)
{
    Console.WriteLine ($"{a} -> да");
}

else 
{
    Console.WriteLine ($"Число не является днем недели");
}