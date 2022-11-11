// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
}

ShowNums(5);
*/

// Решение 2 :)
/*
void ShowNums(int n, int one)
{
    if(one < n) ShowNums(n, one + 1);
    Console.Write(one + " ");
}

ShowNums(8, 1);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfNums(int m, int n)
{

    if(m > n) return m + SumOfNums(m - 1, n);

    if(n > m) return n + SumOfNums(m, n - 1);

    else return m;
}

Console.WriteLine(SumOfNums(4, 8));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AckermannFunction(int m, int n)
{
    if(m == 0) return n = n + 1;
    if(m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    if(m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    else return 0;
}

Console.WriteLine(AckermannFunction(3, 0));
*/