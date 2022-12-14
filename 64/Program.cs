// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int N = GetNumberFromUser("Введите число: ","Ошибка ввода!");
Console.Write($"N = {N}: ");
Numbers(N, 1);




//____________вывод в обратном порядке от N до 1__________//
void Numbers(int n, int m)
{
    if(n > m)
    {
        Console.Write($"{n}, ");
        Numbers(n - 1, m);
    }
    else  if (n == m)
    {
        Console.Write($"{n}");
    }
}

//_______________получение числа от пользователя____________//
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