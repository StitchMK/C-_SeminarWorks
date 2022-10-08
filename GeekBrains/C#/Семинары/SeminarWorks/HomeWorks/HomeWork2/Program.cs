//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

/*
int MiddleDigit (int num)
{   
    int num1 = num % 100;
    int num2 = num1 / 10;
    
    return num2;
}
Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int middleNumber = MiddleDigit(num);
Console.WriteLine($"The middle digit of {num} is {middleNumber}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

/*
char ThirdDigit (string num)
{   
    char n3 = num[2];
    return n3;
}
Console.Write("Input a number: ");
string num = Console.ReadLine();
int length = num.Length;
if(length < 3)
{
    Console.WriteLine($"The number {num} has not the third digit");
}
else
{
    Console.WriteLine($"The third digit of {num} is {ThirdDigit(num)}");
}
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

int ThirdDigit (int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100)
{
    Console.WriteLine($"The number {num} has not the third digit");
}
else
{
    int thirdDigit = ThirdDigit(num);
    Console.WriteLine($"he third digit of {num} is {thirdDigit}");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

/*
bool DayOfRest (int num)
{   
    bool result;
    if(num == 6 || num == 7)
        result = true;
    else
        result = false;
    return result;
}
Console.Write("Input the number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());
bool dayOfRest = DayOfRest(num);
Console.WriteLine($"The day number {num} is the day of rest: {dayOfRest}");
*/