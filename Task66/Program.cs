/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

int userNumberM = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int userNumberN = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");

int result = 0;
Console.Write($"M = {userNumberM}; N = {userNumberN} -> ");

if (userNumberM < userNumberN)
    result = SumMN(userNumberM, userNumberN, result);
else
    result = SumMN(userNumberN, userNumberM, result);

Console.Write(result);

////////////////////////////////
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


int SumMN(int userNumberM, int userNumberN, int result)
{
    if (userNumberM > userNumberN)
    {
        return result;
    }
    result = result + userNumberM;
    return(SumMN(userNumberM + 1, userNumberN, result));

}

