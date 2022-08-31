// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
/*
double [,] CreateRandom2dRealNumberArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = Math.Round(Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) + new Random().NextDouble(), 1);

    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write ("Введите количество строк: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите количество столбцов: ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());

double[,] myArray = CreateRandom2dRealNumberArray(m,n,min,max);
Show2dArray(myArray);
*/
/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void CheckElementsArray (int[,] array, int rowEl, int columnEl)
{
    if (rowEl >= 0 && rowEl < array.GetLength(0) && columnEl >= 0 && columnEl < array.GetLength(1))
    {
        Console.WriteLine($"Элемент массива с индексами {rowEl},{columnEl} равен: {array[rowEl,columnEl]}");
    }
    else
    {
        Console.WriteLine($"Элемента с индексами {rowEl},{columnEl} в данном массиве не существует");
    }
}

Console.Write ("Введите количество строк: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите количество столбцов: ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());


Console.Write ("Введите номер строки элемента: ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите номер столбца элемента: ");
int column = Convert.ToInt32 (Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
CheckElementsArray(myArray,row,column);
*/
/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int [] FindAverageElementsColumn (int[,] array)
{
    int[] averageArray = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i,j];           
        averageArray[j] = sum / array.GetLength(0);
    }
    return averageArray;
}

Console.Write ("Введите количество строк: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите количество столбцов: ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);

int[] resultArray = FindAverageElementsColumn(myArray);
ShowArray(resultArray);
*/