// HomeWork001
/*
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
*/
// Вариант 2 с ошибкой

Console.Write("Input a number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
    max = number2;
if (number1 == number2)
    Console.WriteLine("The numbers are equal");
Console.WriteLine("The maximum of two numbers is " + max);


/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input a number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{ 
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine("The maximum of three numbers is " + max);
*/
/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Enter a number to check: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Our number is even");
}
else
{
    Console.WriteLine("Our number is odd");
}
*/
/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i=1; i <= num; i++)
{
    if (i %2 == 0)
    {
        Console.Write(i + " ");
    }
}
*/


    