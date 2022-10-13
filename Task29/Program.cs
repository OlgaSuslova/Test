// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();
int userNumber1 = GetNumberFromUser("Enter number 1: ", "Error");
int userNumber2 = GetNumberFromUser("Enter number 2: ", "Error");
int userNumber3 = GetNumberFromUser("Enter number 3: ", "Error");
int userNumber4 = GetNumberFromUser("Enter number 4: ", "Error");
int userNumber5 = GetNumberFromUser("Enter number 5: ", "Error");
int userNumber6 = GetNumberFromUser("Enter number 6: ", "Error");
int userNumber7 = GetNumberFromUser("Enter number 7: ", "Error");
int userNumber8 = GetNumberFromUser("Enter number 8: ", "Error");

int[] array = {userNumber1, userNumber2, userNumber3, userNumber4, userNumber5, userNumber6, userNumber7, userNumber8};
PrintArray(array);


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


void PrintArray(int[] collection)
{
   Console.Write (" -> [");
   int count = collection.Length;
   int position = 0;
   while (position < count-1)
   {
    Console.Write (collection[position]);
    Console.Write (", ");
    position++;
   }
   Console.Write(collection[7]);
   Console.Write (" ]");
}

