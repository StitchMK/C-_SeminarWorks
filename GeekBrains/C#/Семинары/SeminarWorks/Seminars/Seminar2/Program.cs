// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

/*
int FindBiggestDigit(int num)
{
    int max;
    
    int ed = num % 10;
    int dec = num / 10;
    if(ed > dec)
        max = ed;
    else
        max = dec;
    
    return max;
}
int number = new Random().Next(10, 100);
int biggestDigit = FindBiggestDigit(number);
Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

// Задача 2. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

/*
int TwoDigitNumber (int num)
{
    int result;
    int ed = num % 10;
    int dec = num / 100;
    result = dec * 10 + ed;
    return result;
}
int number = new Random().Next(100, 1000);
int twoDigitNumber = TwoDigitNumber(number);
Console.WriteLine($"The Tbiggest digit of {number} is {twoDigitNumber}");
*/


// Задача 3. Напишите программу, которая принимает на вход число (N) и проверяет, 
// кратно ли оно одновременно a и b.
// a и b - инфо от пользователя(тоже int)

/*
bool MultipleNumber (int number, int a, int b)
{
    bool result;
    if(number % a == 0 && number % b == 0)
    
        result = true;
    else
        result = false;
    
    return result;
    
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first divider: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second divider: ");
int b = Convert.ToInt32(Console.ReadLine());
bool multipleNumber = MultipleNumber(number, a, b);
Console.WriteLine($"The Number {number} divide into {a} and {b}: {multipleNumber}");
*/