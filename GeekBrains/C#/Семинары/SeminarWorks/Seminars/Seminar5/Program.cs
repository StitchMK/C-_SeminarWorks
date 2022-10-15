// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("/nComplete!");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");   

    Console.WriteLine();
}

int SumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }

    return sum;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");   

    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
int result = SumOfNegatives(myArray);

ShowArray(myArray);

Console.WriteLine("Sum of a negative elements is" + result);
*/

// Задача 2. Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
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

int[] Permutation(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}


Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int[] reversed = Permutation(myArray);
ShowArray(reversed);
*/


// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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

bool Find(int num, int[] array)
{   
    bool find = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) 
        {
            find = true;
            break;
        }
    }
    return find;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a desired number: ");
int num = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

bool find = Find(num, myArray);
Console.WriteLine($"A number {num} is in our array: {find}");
*/

// Задача 4. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99] ([m,n]).
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

int minValue = 10;
int maxValue = 99;
int Count(int[] array, int minValue, int maxVAlue)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= minValue && array[i] <= maxValue) count++;
    }
    return count;
}

int[] arrayToFind = CreateRandomArray(12, -100, 150);
ShowArray(arrayToFind);
int count = Count(arrayToFind, minValue, maxValue);
Console.WriteLine($"In your array are {count} elements in range from {minValue} to {maxValue}");
*/