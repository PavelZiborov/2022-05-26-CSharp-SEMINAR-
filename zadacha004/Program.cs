/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

char[] Convert(int number) // переводит двоичное число в десятичное 
{
    string result = string.Empty;
    while (number >= 1)
    {
        int ostatok = number % 2;
        number = number / 2;
        result = result + ostatok.ToString();
    }
    char[] doubleNumber = result.ToCharArray();
    Array.Reverse(doubleNumber);
    return doubleNumber;
}

void PrintArray(char[] charr) // Печатает массив чаров 
{
    for (int i = 0; i < charr.Length; i++)
    {
        Console.Write(charr[i]);
    }
    Console.WriteLine();
}

Console.WriteLine("Введите десятичное число, которое хотите преобразовать в двоичное: ");
int number = int.Parse(Console.ReadLine());
char[] doubleNumber = Convert(number);
PrintArray(doubleNumber);