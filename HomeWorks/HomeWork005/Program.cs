// HomeWork5
/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomFreeDigitsArray (int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100,1000);
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

int CountEvenNumber (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) count++;
    }
    return count;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomFreeDigitsArray (a);
ShowArray(myArray);
int result = CountEvenNumber(myArray);
Console.WriteLine($"The number of even numbers in the array is {result}. ");
*/
/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumOddElements (int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i = i+2)
    {
        sumOdd += array[i];
    }
    return sumOdd;
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);

int result = SumOddElements(myArray);
Console.WriteLine($"The sum odd elements of array is {result}. ");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.

double[] CreateRandomArray (int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray; 
} 

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


double DifferenceMaxMinElements (double[] array)
{
    double maxEl = 0;
    double minEl = 0;
    for (int i = 0; i < array.Length; i++)
    {      
        if (array[i] < minEl) minEl = array[i];
        if (array[i] > maxEl) maxEl = array[i];
    }
    return  (maxEl - minEl);
}


Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
double result = DifferenceMaxMinElements(myArray);
Console.WriteLine($"The difference between the maximum and minimum elements of the array is {result}. ");

// Пробовал различные варианты исполнения, но программа все равно выдает максимальный элемент массива. Не могу понять почему не считает разницу?
