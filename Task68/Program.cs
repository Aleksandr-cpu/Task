// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAckerman(int m, int n)
{
    if (m == 0)
    return n + 1;
    if ((m != 0) && (n == 0))
      return FunctionAckerman(m - 1, 1);
    else
      return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
}

Console.WriteLine("Введите неотрицательное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

Console.Write($"M = {numberM}; N = {numberN} -> {FunctionAckerman(numberM, numberN)}");