// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
double GetNumberFromConsole()
{
    return Convert.ToDouble(Console.ReadLine());
}

void WriteNumbersRecursion(int endNumber, double startNumber)
{
    startNumber -= startNumber % 1;
    if (startNumber >= endNumber)
    {
        Console.Write(startNumber + ", ");
        WriteNumbersRecursion(endNumber, startNumber - 1);
    }
}

WriteNumbersRecursion(1, GetNumberFromConsole());