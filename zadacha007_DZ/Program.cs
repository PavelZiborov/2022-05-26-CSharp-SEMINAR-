/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
y = k1 * x + b1
y = k2 * x + b2;

значения b1, k1, b2 и k2 задаются пользователем.

Пример:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetNumber(string message) // метод который принимает от пользователя число, проверяет что бы он не ошибся
{
    Console.Write(message);
    bool success = true;
    double inputResult = 0;
    while (success)
    {
        string numberFromConsole = Console.ReadLine();
        if (double.TryParse(numberFromConsole, out double result))
        {
            inputResult = result;
            success = false;
        }
        else
        {
            Console.Write("Вы ввели не число. Введите число: ");
        }
    }
    return inputResult;
}

double b1 = GetNumber("Введите b1: ");
double k1 = GetNumber("Введите k1: ");
double b2 = GetNumber("Введите b2: ");
double k2 = GetNumber("Введите k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"({x}; {y})");

