//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
int A = GetNumberFromUser1("Введите число А: ", "Ошибка ввода!");
int B = GetNumberFromUser2("Введите число В: ", "Ошибка ввода!");
int Pow = GetPow(A, B);
Console.WriteLine($"Число A в натуральной степени B = {Pow}");

int GetNumberFromUser1(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber1))
            return userNumber1;
        Console.WriteLine(errorMessage);
    }
}

int GetNumberFromUser2(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber2))
            return userNumber2;
        Console.WriteLine(errorMessage);
    }
}
int GetPow(int A, int B)
{
    int Pow = 1;

    while (B!=0)
    {
        Pow = A * Pow;
        B = B - 1;
    }
    return Pow;
}
