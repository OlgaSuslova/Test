/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */


Console.Clear();

int userNumberM = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int userNumberN = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");

int result = Akkerman(userNumberM, userNumberN);

Console.Write($"A({userNumberM}, {userNumberN}) = ");
Console.Write(result);

///////////////////////////////////////////////////////////
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int Akkerman(int m, int n)
{
    while (m != 0)
    {
        m -= 1;
        if(n == 0)
            n = 1;
        else
            n = Akkerman(m + 1, n - 1);
    }
    return n + 1;
}