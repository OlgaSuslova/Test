// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();

int k1 = GetNumberFromUser("Enter k1: ", "Error");
int b1 = GetNumberFromUser("Enter b1: ", "Error");
int k2 = GetNumberFromUser("Enter k2: ", "Error");
int b2 = GetNumberFromUser("Enter b2: ", "Error");

double coordinateX =  FindCoordinateX(k1, b1, k2, b2);
double coordinateY =  FindCoordinateY(coordinateX, k1, b1);

Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({coordinateX}, {coordinateY}) ");


//////////////////////////////////////////////////////////
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

double FindCoordinateX (int k1, int b1, int k2, int b2)
{
    double X = (double) (b2 - b1) / (k1 - k2);
    return X;
}

double FindCoordinateY (double coordinateX, int k1, int b1)
{
    double Y = k1 * coordinateX + b1;
    return Y;
}