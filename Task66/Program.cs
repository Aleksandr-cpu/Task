// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumOfNaturalElementsInTheInterval(int m, int n)
{
    if (m > n)
        return m + SumOfNaturalElementsInTheInterval(m - 1, n);
    if (m < n)
        return n + SumOfNaturalElementsInTheInterval(m, n - 1);
    else return m;
}

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

Console.Write($"M = {numberM}; N = {numberN} -> {SumOfNaturalElementsInTheInterval(numberM, numberN)}");
