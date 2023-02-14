/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("введите начало промежутка");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNum(start));

string PrintNum(int start)
{
    if (start == 1)
    {
        return start.ToString();
    }
    return(start + " " + PrintNum(start - 1));
}