// Seminar 4
/*
// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму
// чисел от 1 до А.

int FindSum (int number)
{
    int factorial = 0;
    for (int i = 1; i <= number; i++)
        factorial = factorial + i;
        // factorial += i - другая запись предыдущего выражения.
    return factorial;
}

Console.WriteLine("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} is {result}");
// Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}"); -можно записать
// так, тогда 17 строка с "int result = FindSum(a);" не нужна
*/
/*
// Задача. Напишите программу, которая принимает на вход число и выдаёт количество
// цифр в числе.

int FindDigits (int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number /10;
        count ++;
    }
    return count;
}

Console.WriteLine("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The number of digits in the number {a} is equal to {FindDigits(a)}");
*/
/*
// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.

int FindFactorial (int number)
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
        factorial = factorial * i;
    return factorial;
}
Console.WriteLine("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The factorial of number {a} is equal to {FindFactorial(a)}");
*/

// Задача 4. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.


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

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);

