// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int N = GetNumberFromUser("Введите первое число промежутка N: ","Ошибка ввода!");
int M = GetNumberFromUser("Введите второе число промежутка M: ","Ошибка ввода!");
int sum = SumNumbers(N, M);
Console.Write($"При (N = {N}; M = {M}) Сумма чисел: {sum}");



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

//_______________сумма элементов  в промежутке от N до M____________//
int SumNumbers(int n, int m)
{
    if(n == m) 
        return n;
    else 
        return n + SumNumbers(n + 1, m);
}