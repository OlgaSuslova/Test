// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int number = GetNumberFromUser("Enter your number: ", "Error");
int sum = GetSumNumber (number);
Console.WriteLine($"{number} -> {sum}");


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber) && userNumber > 0;
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetSumNumber(int number)
{
   int sum = 0; 
    while (number>0)
    {
        int last = number % 10;
        number = number/10; 
        sum = sum + last;  
    }
   
    return sum;
}
