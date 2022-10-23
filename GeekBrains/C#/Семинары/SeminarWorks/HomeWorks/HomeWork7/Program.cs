// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 1);
    
    return array;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
            Console.WriteLine();
    }
}
double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns]; 
    for( int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
            Console.WriteLine();
    }
}

int FindElement(int[,] array, int row, int column)
{   

    while(row >= array.GetLength(0) || column >= array.GetLength(1))
    {
        Console.WriteLine("An array element with the entered index doesn't exist. Input another values.");
        Console.Write("Input a row of element: ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a column of element: ");
        column = Convert.ToInt32(Console.ReadLine()); 

    }

    int num = array[row,column];        

    return num;
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.Write("Input a row of element: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column of element: ");
int column = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine($"An array element with the entered index is {FindElement(myArray, row, column)}");
*/

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns]; 
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
            Console.WriteLine();
    }
}

double[] ArithmeticMean(int[,] array)
{   
    double sum = 0;
    double[] newArray = new double[array.GetLength(1)]; 
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j]; 
            newArray[j] = Math.Round(sum / array.GetLength(0), 1); 
        }
        sum = 0;
    }

    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + "  ");   
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
double [] newArray = ArithmeticMean(myArray);
Console.WriteLine("Arithmetic mean values of column elements are: ");
ShowArray(newArray);
*/


// additional solution
// Комментарий от Павла Гуляева:
// В последней задаче рекомендую записывать значения в одномерный массив после работы внутреннего цикла, 
// а не внутри него, чтобы помногу раз не перезаписывать значения :)

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns]; 
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
            Console.WriteLine();
    }
}

double[] ArithmeticMean(int[,] array)
{   
    double sum = 0;
    double[] newArray = new double[array.GetLength(1)]; 
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j]; 
        }
        newArray[j] = Math.Round(sum / array.GetLength(0), 1); 
        sum = 0;
    }

    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + "  ");   
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
double [] newArray = ArithmeticMean(myArray);
Console.WriteLine("Arithmetic mean values of column elements are: ");
ShowArray(newArray);
*/
