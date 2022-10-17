// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16
 
 
Console.Clear();
int number1 = GetNumberFromUser("Enter number A: ", "Error");
int number2 = GetNumberFromUser("Enter number B: ", "Error");

double result = NumbersProduct(number1, number2);
Console.WriteLine($"{number1}, {number2} -> {result}");



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

double NumbersProduct(int number1, int number2)
{
      double res = 0;
        for (int i = 1; i < number2; i++)
           {
               res = number1 * number2;
           }
        return res;

    
}




