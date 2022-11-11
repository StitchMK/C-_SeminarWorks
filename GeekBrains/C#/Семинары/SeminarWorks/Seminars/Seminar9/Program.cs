// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    if(n > 1) ShowNums(n - 1);

    Console.Write(n + " ");
}

ShowNums(5);
*/

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(12345));
*/

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int n, int m)
{

    if(n > m) 
    {   ShowNums(n - 1, m);
        Console.Write(n + " ");
    }
    if(m > n) 
    {
        ShowNums(n, m - 1);
        Console.Write(m + " ");
    }
}

ShowNums(5, 3);
*/
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double DegreeOfNumber (int a, int b)
{
    if(b > 0) return DegreeOfNumber(a, b - 1) * a;
    if(b < 0) return 1/((DegreeOfNumber(a, - b - 1)) * a);
    else return 1;
}

Console.WriteLine(DegreeOfNumber(2, -1));
Console.WriteLine(DegreeOfNumber(2, -2));
Console.WriteLine(DegreeOfNumber(2, -3));
Console.WriteLine(DegreeOfNumber(2, -4));
Console.WriteLine(DegreeOfNumber(2, -5));
Console.WriteLine(DegreeOfNumber(2, -6));
Console.WriteLine(DegreeOfNumber(2, -7));