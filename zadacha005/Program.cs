/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

List<int> Fibonaci(int n)
{
    List<int> fib = new List<int>();
    fib.Add(0);
    fib.Add(1);
    for (int i = 2; i < n; i++)
        fib.Add(fib[i - 1] + fib[i - 2]);
    return fib;
}

// void FibArray(int n)
// {
//     Console.Write(" 0 1 ");
//     int sum1 = 0;
//     int sum2 = 1;
//     int temp;
//     for (int i = 2; i < n; i++)
//     {
//         temp = sum1 + sum2;
//         Console.Write($"{temp} ");
//         sum1 = sum2;
//         sum2 = temp;
//     }

// }

// void printList(List<int> list)
// {
//     for (int i = 0; i < list.Count; i++)
//         Console.WriteLine($"{i + 1} = {list[i]}");
// }

// void printListLine(List<int> list)
// {
//     for (int i = 0; i < list.Count; i++)
//         Console.Write($"{list[i]} ");
// }

// Console.Write("Введите N * больше или равно 2: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write($"N = {n} - > ");
// printListLine(Fibonaci(n));
// Console.Write("\n\n");

// printList(Fibonaci(n));
// Console.Write("\n\n");
// FibArray(n);

Console.WriteLine();
/*
1. метод который принимает число N
2. метод который считает числа Фибоначи от 0 до N
3. метод который печатает числа Фибоначи
*/

int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[] FibonacciNumbers(int number)
{
    double[] array = new double[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i+1}. {array[i]}");
    }
    Console.Write("\n");
}

int number = GetNumber("Введите N чисел Фибоначчи: ");
double[] fibonacci = FibonacciNumbers(number);
PrintArray(fibonacci);