// HomeWork001

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Вариант 1 рабочий
Console.Write("Input a number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
    max = number2;
Console.WriteLine("The maximum of two numbers is " + max);

// Вариант 2 с ошибкой
/*
Console.Write("Input a number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
    max = number2;
if (number1 = number2)
    Console.WriteLine("The numbers are equal");
Console.WriteLine("The maximum of two numbers is " + max);
*/
