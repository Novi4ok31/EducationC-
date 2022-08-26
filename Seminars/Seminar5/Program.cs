// Seminar 5
// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов 
// массива.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray; 
} 

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FindMinMaxSum (int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]>0)
        sumPositive += array[i];
       else sumNegative += array[i];
    }
    Console.WriteLine($"sum of negative elements is {sumNegative}");
    Console.WriteLine($"sum of positive elements is {sumPositive}");
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
FindMinMaxSum(myArray);
*/
// Задача 2. Напишите программу замены элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray; 
} 

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] ChangeElements (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = array[i] * (-1);
    }
    return array;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
ShowArray(ChangeElements(myArray));
*/
/*
// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует 
// ли заданное число в массиве.

int[] CreateArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        {
        Console.Write($"Input {i} element of the array: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());    
        }
    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

bool FindNumber (int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true; // return if (array[i] == n)
    }
    return false;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number for check: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray (a);
ShowArray(myArray);
bool result = FindNumber(myArray, n);
if (result == true) Console.WriteLine($"Число {n} найдено в заданном массиве");
else 
    Console.WriteLine($"Число {n} не найдено в заданном массиве");
*/

// Задача 4. Задайте одномерный массив из 12 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray; 
} 

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountElements (int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>=min && array[i]<=max) count++;
    }
    return count;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);

Console.Write("Input min segment value: ");
int minsegment = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max segment value: ");
int maxsegment = Convert.ToInt32(Console.ReadLine());

int result = CountElements(myArray, minsegment, maxsegment);
Console.WriteLine($"Count elements of segment {minsegment}-{maxsegment} in array is {result} ");

