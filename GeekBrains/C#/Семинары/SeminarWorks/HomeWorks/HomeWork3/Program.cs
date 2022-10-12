// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.



void Palindrome(int number)
{
    int count = 1;
    int length = number.ToString().Length;
    double degree = Math.Pow(10, (length - 1));
    int degree1 = Convert.ToInt32(degree);
    while(count <= (length / 2))
     {
        if(number % 10 == number / degree1)
        {
            number = number % 10 / degree1;
            count++;
            if(number <= 9)
            {
                Console.WriteLine($"Your number is a palindrome");
            }
        }
        else
        {
            Console.WriteLine($"The number {number} is not a palindrome");
        }
        break;
     }
}

Console.Write("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

/*

double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
{   
    double sumAB = Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2);
    double distance = Math.Round(Math.Sqrt(sumAB), 2);
    return distance;
}
Console.Write("Input x-coordinate of point A: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate of point A: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z-coordinate of point A: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x-coordinate of point B: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate of point A: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z-coordinate of point A: ");
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The distance between A({xa}, {ya}, {za}) and B({xb}, {yb}, {zb}) is: {FindDistance(xa, ya, za, xb, yb, zb)}");

*/

// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

/*

void FindCubeOfNumbers(int number)
{
    int count = 1;
    while(count <= number)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}
Console.WriteLine("Input a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindCubeOfNumbers(number);

if(number <= 0) 
{
    Console.Write("Incorrect input");
}

*/