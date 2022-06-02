/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] InitArray(string text) // метод который принимает от пользователя числа через запятую, формирует из них массив и выводит на консоль
{
    Console.WriteLine("\nВы ввели следующий массив чисел: ");
    string[] arrayStr = text.Replace(" ", "")
                            .Split(',');
    int[] array = new int[arrayStr.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (int.TryParse(arrayStr[i], out int result))
        {
            array[i] = result;
            Console.Write($"{array[i]}  ");
        }
    }
    Console.Write("\n\n");
    return array;
}

void CountingPositiveNumbers(int[] array) // метод который считает количество положительных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Число положительных чисел в массиве = {count}");
}

Console.Write("Введите числа, разделяя их запятой: ");
string text = Console.ReadLine();
int[] array = InitArray(text);
CountingPositiveNumbers(array);