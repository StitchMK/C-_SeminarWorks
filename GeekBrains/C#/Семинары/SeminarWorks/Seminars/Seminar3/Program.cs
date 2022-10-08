// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int FindQuart (double x, double y)
{
    int quart = 0;
    if(x > 0 && y > 0) quart = 1;
    if(x < 0 && y > 0) quart = 2;
    if(x < 0 && y < 0) quart = 3;
    if(x > 0 && y < 0) quart = 4;
    
    return quart;
}
Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The point A({x},{y}) is on the {FindQuart(x,y)} quart");
*/

// Задача 2. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void FindCoordinateRange (int quart)
{   
    if(quart == 1)
{
        Console.Write("В этой четверти x и у принимают положительные значения");
    }
    if(quart == 2)
    {
        Console.Write("В этой четверти x принимает значения от 0 до минус бескончности, у принимает значения от нуля до плюс бесконечности");
    }
    if(quart == 3)
    {
        Console.Write("В этой четверти x принимает значения от 0 до минус бескончности, у принимает значения от нуля до минус бесконечности");
    }
    if(quart == 4)
    {
        Console.Write("В этой четверти x принимает значения от 0 до плюс бескончности, у принимает значения от нуля до минус бесконечности");
    }
    
}
Console.Write("Input a quart");
int quart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The Coordinate Range of {quart} is: ");
FindCoordinateRange(quart);
*/

// Задача 3. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

/*
double FindDistance (double xa, double ya, double xb, double yb)
{   
    double sumAB = Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2);
    double distance = Math.Sqrt(sumAB);
    return distance;
}
Console.Write("Введите координату x точки А: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y точки А: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Расстояние между точками равно: {FindDistance(xa, ya, xb, yb)}");
*/

// Задача 4. Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.

/*
void FindSquareeOfNumbers(int number)
{
    int count = 1;
    while(count <= number)
    {
        Console.WriteLine(Math.Pow(count, 2));
        count++;
    }
}
Console.WriteLine("Input a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindSquareeOfNumbers(number);
if(number <= 0) 
{
    Console.Write("Incorrect input");
}
*/