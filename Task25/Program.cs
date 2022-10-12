﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16
 
 
Console.Clear();
int number1 = GetNumberFromUser("Enter your first number: ", "Error");
int number2 = GetNumberFromUser("Enter your second number: ", "Error");

int result = NumbersProduct(number1, number2);
Console.WriteLine($"{number1}, {number2} -> {result}");



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

int NumbersProduct(int number1, int number2)
{
    int result = Convert.ToInt32 (Math.Pow (number1, number2));
    return result;
}



