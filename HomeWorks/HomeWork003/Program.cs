
// ДЗ 3. 


//Задача 1.Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void FindPalindrome (int number)
{
    int digit1 = number / 10000;
    int digit2 = number % 10000 / 1000;
    int digit4 = number % 10000 % 1000 % 100 /10;
    int digit5 = number % 10000 % 1000 % 100 % 10;
    if (digit1 == digit5 && digit2 == digit4)
        Console.WriteLine($"The five-digit number {number} is a palindrom");
    else 
        Console.WriteLine($"The five-digit number {number} is not a palindrom");
} 

Console.Write ("Inut a five-digit number: ");
int result = Convert.ToInt32(Console.ReadLine());
FindPalindrome(result);
*/
/*
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Не знаю как вычисляется расстояние в 3D. Сделал по образу и подобию 2D, результат
// не сходится с приведенными примерами в задаче. 

double FindDistance(double xA, double yA, double xB, double yB, double zA, double zB)
{
   return Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2) + Math.Pow(zB-zA, 2));
}

Console.Write("Input the x coordinate of the first point: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the y coordinate of the first point: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the z coordinate of the first point: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the x coordinate of the second point: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the y coordinate of the second point: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the z coordinate of the second point: ");
double zB = Convert.ToDouble(Console.ReadLine());


double result = FindDistance(xA,yA,zA,xB,yB,zB);
Console.WriteLine($"Distance is {result} ");
*/
/*
//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void OutputsCube (int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"The cube of the number {i} is equal to {i*i*i};");
    }
}

Console.Write("Enter any integer: ");
int cube = Convert.ToInt32(Console.ReadLine());
OutputsCube(cube);
*/

