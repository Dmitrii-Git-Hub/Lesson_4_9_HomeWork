// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

double GetNumberFromConsole()
{
    return Convert.ToDouble(Console.ReadLine());
}

void WriteSumNaturalNumbersInRange(double M, double N)
{
    M -= M % 1;
    N -= N % 1;
    double sum = 0;
    for (double i = M; i <= N; i++)
    {
        sum += i;
    }
    Console.Write(sum);
}

WriteSumNaturalNumbersInRange(GetNumberFromConsole(), GetNumberFromConsole());