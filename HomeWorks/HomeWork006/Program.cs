// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.

/*
int [] CreateUserArray (int size)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} number of array: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int CountPositivNumber (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count ++;
    }
    return count;
}

Console.Write("Input size for array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateUserArray (size);
ShowArray(myArray);
int result = CountPositivNumber(myArray);
Console.WriteLine($"The number of positive numbers in the array is {result}");
*/
/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void PointIntersection (double a1, double c1, double a2, double c2)
{
    double x = (c2 - c1) / (a1 - a2);
    double y = a1 * x + c1;
    if (a1==a2) Console.WriteLine("Straight parallel");
    else Console.WriteLine($"The point of intersection of the lines has coordinates ({x},{y})");
}

Console.WriteLine ("Input the coefficient k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input the coefficient b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input the coefficient k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input the coefficient b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

PointIntersection(k1,b1,k2,b2);
*/

