/*
Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

int GetNumber(string message) // метод который получает число
{
    Console.Write(message);
    int str = int.Parse(Console.ReadLine());
    return str;
}

bool ExistenceTest(int lineA, int lineB, int lineC) // метод который проверяет на существование треугольника
{
    bool test1 = (lineA + lineB) > lineC;
    bool test2 = (lineA + lineC) > lineB;
    bool test3 = (lineC + lineB) > lineA;
    return test1 && test2 && test3;
}

int lineA = GetNumber("Введите длину стороны А: ");
int lineB = GetNumber("Введите длину стороны B: ");
int lineC = GetNumber("Введите длину стороны C: ");

bool result = ExistenceTest(lineA, lineB, lineC);
if (result) Console.WriteLine("Треугольник существует.");
else Console.WriteLine("Такого треугольника не существует.");

