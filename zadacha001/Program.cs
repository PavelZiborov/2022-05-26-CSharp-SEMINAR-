// программа которая принимает число и считает сумму цифр этого числа

var number = int.Parse(Console.ReadLine()); // var - автоопределение 
var str = number.ToString();
int summ = 0;
for (int i = 0; i < str.Length; i++)
{
    summ += int.Parse(str[i].ToString());
}
Console.WriteLine($"Сумма чисел = {summ}");