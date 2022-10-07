int EnterNumber()
{
int number;
    while (true)
    {
        Console.Write ("Введите число: ");
        if (int.TryParse (Console.ReadLine(), out number))
           break;
        Console.WriteLine ($"Ошибка ввода!");   
    }
    return number;
}

int A = EnterNumber();
if ( A < 100 )
{
  Console.WriteLine ($"{A} -> третьей цифры нет");
}

else if ( A>99 && A<1000 )
{
  Console.WriteLine ($" {A} -> {A%10}");
}

else if ( A>999 && A<10000 ) 
{
  Console.WriteLine ($"{A} -> {(A/10)%10}");
}

else if ( A>9999 && A<100000 )
{
  Console.WriteLine ($"{A} -> {(A/100)%10}");
}
else if ( A>99999 && A<1000000 )
{
    Console.WriteLine ($"{A} -> {(A/1000)%10}");
}

else if ( A>999999 && A<10000000 )
{
    Console.WriteLine ($"{A} -> {(A/10000)%10}");
}

else
{
  Console.WriteLine ("Большое число!");
}

