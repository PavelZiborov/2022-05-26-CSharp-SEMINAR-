/*
Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

/*
1. метод, который инициализирует массив случайными числами
2. метод, который печатает массив на консоль
3. метод, который переворачивает массив наоборот
*/

int[] GetArray(int length) //метод, который инициализирует массив случайными числами
{
    int[] array = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 15);
    }
    return array;
}


void PrintArray(int[] array) //метод, который печатает массив на консоль
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}


int[] ReverseArray(int[] array) //метод, который переворачивает массив наоборот и возвращает новый массив
{
    int[] result = new int[array.Length];
    int resultCount = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[resultCount] = array[i];
        resultCount++;
    }
    return result;
}


void ReverseArraySelf(int[] array) //перевернет массив сам себя
{
    Array.Reverse(array);
}



Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());

int[] array = GetArray(length);
PrintArray(array);
Console.WriteLine("<- Изначально мы получили такой массив");

int[] reversedArr = ReverseArray(array);
PrintArray(reversedArr);
Console.WriteLine("<- Новый перевернутый массив");

Array.Reverse(array); // переворачивает массив
PrintArray(array);
Console.WriteLine("<- Изначальный массив который мы перевернули. Т.е. изменили исходный массив");