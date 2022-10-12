//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
int num = GetNumberFromUser("Введите пятизначное число: ","Ошибка ввода!");

int oldNumber = num;
int newNumber = 0;
while (num>0)
{
    int dif = num % 10;
    newNumber = newNumber * 10 + dif;
    num = num / 10;
}

if (newNumber == oldNumber)
{
    Console.WriteLine ($"{oldNumber} -> да ");
}
else 
{
    Console.WriteLine ($"{oldNumber} -> нет "); 
}




int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
      {
         Console.Write(message);
         bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
         if(isCorrect)
           return userNumber;

        Console.WriteLine(errorMessage);
      } 
}
