// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int GetSum(int a)
{
    int sum = 0;
    for(int current = 1; current <= a; current++)
    {
        sum += current;
    }
    return sum;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);

Console.WriteLine($"Sum of elements from 1 to {num} is {s}");
*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int NumberOfDigits(int num)
{
    int size = num.ToString().Length;
    return size;
}

Console.Write("Input positive number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = NumberOfDigits(a);
Console.WriteLine(result);
*/

// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int a)
{
    int result = 1;
    for(int current = 1; current <= a; current++)
        result = result * current;
    return result;
}
Console.Write("Input positive number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = Factorial(a);
Console.WriteLine(result);
*/

// Второй вариант задачи 2
/*
int NumberDigits(int num)
{
    int count = 0;
    while(num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.Write("Input positive number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = NumberDigits(a);
Console.WriteLine(result);
*/

// Задача 4. Напишите программу, которая выводит массив из m элементов, 
// заполненный нулями и единицами в случайном порядке.

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
int max = 9;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/
