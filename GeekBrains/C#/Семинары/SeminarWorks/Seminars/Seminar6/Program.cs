// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*
void ChangeNumber(int a)
{
    a += 5;
    Console.WriteLine(a);
}

int num = 5;

ChangeNumber(num);
Console.WriteLine(num);

*/

// Решение задачи:
/*

int[] CreateRandomArray()
{   
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min, max +1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");   
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for(int i = 0, last = array.Length - 1; i < last; i++, last--)
    {
        int temp = array[i];
        array[i] = array[last];
        array[last] = temp;
    }
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

/*
void ChangeFirstElement(int[] array)
{
    array[0] += 5;
}
*/

/*
int[] myArray = CreateRandomArray();
ShowArray(myArray);
ChangeFirstElement(myArray);
ShowArray(myArray);
*/

// Задача 1. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
/*
bool IfTriangle(int a, int b, int c)
{
    if(a < b + c && b < c + a && c < a + b) return true;
    else return false;
}
    
Console.Write("Введите длину стороны A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны C: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = IfTriangle(a, b, c);
Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует: {result}");
*/

// Задача 2. Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.
/*
int[] CreateRandomArray()
{   
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min, max +1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");   
    Console.WriteLine();
}

void ReturnArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
ReturnArray(myArray);
ShowArray(myArray);
*/

// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fibonacci(int n, int a, int b)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    int i = array.Length;
    for(i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + " ");   
    Console.WriteLine();
}


Console.Write("Введите количество элементов массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первый элемент ряда: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй элемент ряда: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] result = Fibonacci(n, a, b);
ShowArray(result);
*/