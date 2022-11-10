// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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

int[,] RowsOrdering(int[,] array)
{   
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1); j++)
            for(int n = 0; n < array.GetLength(1) - 1; n++)
            {
                while(array[i,n+1] > array[i,n]) 
                {
                    int temp = array[i,n]; 
                    array[i,n] = array[i,n+1];
                    array[i,n+1] = temp;
                }
            }
    }

    return array;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
int[,] newArray = RowsOrdering(myArray);
Show2dArray(newArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
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

int [] FindRowsSum (int[,] array)
{   
    int sum = 0;
    int[] newArray = new int[array.GetLength(0)]; 
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j]; 
        }
        newArray[i] = sum; 
        sum = 0;
    }
    return newArray;
}

int FindMax(int[] array)
{
    int min = array[0];
    int indexMin = 0;
    
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) indexMin = i + 1;
    }

    return indexMin; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write($"Row {i + 1}: {array[i]} \n");   
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
int [] newArray = FindRowsSum(myArray);
Console.WriteLine("Row-by-row sum of elements: ");
ShowArray(newArray);
Console.WriteLine($"The minimum sum of elements is in a row number: ");
Console.WriteLine(FindMax(newArray));
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] ProductOfTwoMatrices(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(1), array2.GetLength(0)];
    for(int i = 0; i < array1.GetLength(0); i++)
        for(int j = 0; j < array2.GetLength(1); j++)
            for(int n = 0; n < array1.GetLength(1); n++)
                newArray[i,j] += array1[i,n] * array2[n,j];
    return newArray;

}

Console.WriteLine("Input a number of rows of the first matrix: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns of the first matrix: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int rows2 = columns1;
Console.WriteLine("Input a number of columns of the second matrix: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[rows1, columns1]; 
    for( int i = 0; i < rows1; i++)
        for(int j = 0; j < columns1; j++)
        {
            Console.WriteLine("Input an element of first matrix: ");
            array1[i,j] = Convert.ToInt32(Console.ReadLine());
        }

int[,] array2 = new int[rows2, columns2]; 
    for( int i = 0; i < rows2; i++)
        for(int j = 0; j < columns2; j++)
        {
            Console.WriteLine("Input an element of second matrix: ");
            array2[i,j] = Convert.ToInt32(Console.ReadLine());
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

Console.WriteLine();
Console.WriteLine("Your first matrix is: ");
Show2dArray(array1);
Console.WriteLine();
Console.WriteLine("Your second matrix is: ");
Show2dArray(array2);
Console.WriteLine();
int[,] newArray = ProductOfTwoMatrices(array1, array2);
Console.WriteLine("The result of multiplying two matrices: ");
Show2dArray(newArray);
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
/*
int[,,] CreateRandom3dArray(int rows, int columns, int indexk)
{

    int[,,] array = new int[rows, columns, indexk]; 

    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int  number;
    for (int n = 0; n < temp.GetLength(0); n++)
    {
        temp[n] = new Random().Next(10, 100);
        number = temp[n];
        if (n >= 1)
        {
            for (int m = 0; m < n; m++)
            {
                while (temp[n] == temp[m])
                {
                temp[n] = new Random().Next(10, 100);
                m = 0;
                number = temp[n];
                }
                number = temp[n];
            }
        }
    }
    int count = 0; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = temp[count];
                count++;
            }
        }
    }

    return array;
}
void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            {
                for(int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i,j,k]} ({i}, {j}, {k})" + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of elements of the third dimension of the array: ");
int indexk = Convert.ToInt32(Console.ReadLine());

    if(rows * columns * indexk > 90) 
        Console.Write("The maximum possible number of non-repeating array elements has been exceeded. Array creation is not possible. ");

int[,,] myArray = CreateRandom3dArray(rows, columns, indexk);

Show3dArray(myArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
/*
int[,] CreateSpiral2dArray()
{
    Console.Write("Input a min possible value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns]; 
    array[0,0] = minValue;
    for(int j = 1; j < columns; j++)
        array[0,j] = array[0, j - 1] + 1;

        for(int i = 1; i < rows; i++)
            array[i,columns - 1] = array[i - 1, columns - 1] + 1;

            for(int j = columns - 2; j >= 0; j--)
                array[rows - 1,j] = array[rows - 1, j + 1] + 1;

                for(int i = rows - 2; i > 0; i--)
                    array[i,0] = array[i + 1, 0] + 1;
                                  
                    for(int j = 1; j < columns - 1; j++)
                        array[1,j] = array[1, j - 1] + 1;  

                        for(int i = 2; i < rows - 1; i++)
                            array[i,columns - 2] = array[i - 1, columns - 2] + 1;

                            for(int j = columns - 3; j >= 1; j--)
                                array[rows - 2,j] = array[rows - 2, j + 1] + 1;
                                           
                                 
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < 10)
                Console.Write($"0{array[i,j]} ");
            else
                Console.Write(array[i,j] + " ");
        }

        Console.WriteLine();
    }
}

int[,] myArray = CreateSpiral2dArray();
Show2dArray(myArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Второе решение

int[,] CreateSpiral2dArray()
{
    int rows = 4;
    int columns = 4;
    int dif;
    if(rows > columns) dif = rows - columns;
    else dif = columns - rows;
    int minValue = 1;
    int[,] array = new int[rows, columns];

    int number = 1;
    int i = 0;
    int j = 0;

    while (number <= array.GetLength(0) * array.GetLength(1))
    {
    array[i, j] = minValue;
    minValue++;
    number++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i + dif < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i + dif >= j && i + j + dif > array.GetLength(1) - 1)
        j--;
    else
        i--;
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < 10)
                Console.Write($"0{array[i,j]} ");
            else
                Console.Write(array[i,j] + " ");
        }

        Console.WriteLine();
    }
}

int[,] myArray = CreateSpiral2dArray();
Show2dArray(myArray);
