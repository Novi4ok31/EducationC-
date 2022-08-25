// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
/*
int FindPowTwoNumber (int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA; 
    }
    return result;
}

Console.WriteLine("Input integer number1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input integer number2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"The number {a} to the power of {b} is equal to {FindPowTwoNumber(a,b)}");

*/
 
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму
// цифр в числе.
/*
int SumDigitsNumber (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number  %10;
        number = (number - number %10)/10;
    }        
    return sum;
}

Console.WriteLine("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of digits of the number {a} is equal to {SumDigitsNumber(a)}");
*/
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит 
// их на экран.
/*gi
int[] CreateInputArray (int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i} element array: ");
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

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateInputArray (a);
ShowArray(myArray);

*/
