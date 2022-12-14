// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int N = GetNumberFromUser("Введите первое целое положительное число:  ","Ошибка ввода!");
int M = GetNumberFromUser("Введите второе целое положительное число:  ","Ошибка ввода!");

int result = AkkerMan(N, M);

Console.WriteLine($"M = {M}, N = {N} результат: {result}");

//___________поиск суммы натуральных чисел на промежутке от M до N____________//
int AkkerMan(int m, int n)
{
    if(m == 0) 
        return n + 1;
    else if (m > 0 && n == 0) 
        return AkkerMan(m - 1, 1);
    else 
        return(AkkerMan(m - 1, AkkerMan(m, n - 1)));
}


//______________________числа от пользователя_______________________//
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
