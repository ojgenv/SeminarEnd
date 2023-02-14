/*  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("введите число");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int end = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNum(start, end));

int PrintNum(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return(start + PrintNum(start + 1, end));
}