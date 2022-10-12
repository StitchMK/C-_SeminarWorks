﻿// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

/*
int GetExponentiation (int a, int b)
{
    int product = 1;
    for(int current = 1; current <= b; current++)
    {
        product *= a;
    }
    return product;
}
Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input degree of number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int exponentiation = GetExponentiation(num1, num2);
Console.WriteLine($"The number {num1} to the power {num2} is {exponentiation}");
*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int GetSum(int a)
{
    int sum = 0;
    for(int element = 0; a > 9; sum += element)
    {
        element = a % 10;
        a = a / 10;
    }
    sum += a;
    return sum;
}
Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int s = GetSum(num);
Console.WriteLine($"Sum of elements of {num} is {s}");
*/

// Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);

    return newArray;
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");   

    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 99;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/

// Дополнительное задание (ввод элементов массива пользователем)

/*
int[] CreateArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input an array element in the range from {min} to {max}");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num < 0)
            num = -1 * num;
        newArray[i] = num;
    }

    return newArray;
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");   

    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 99;

int[] myArray = CreateArray(size, min, max);
ShowArray(myArray);
*/