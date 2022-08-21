
// HomeWork002

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutDecNumber(int number)
{
    int dec = number /10;
    dec = dec %10;
    return dec;
}
Console.Write("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = CutDecNumber(number);
Console.WriteLine($"Second digit of three-digit number is {result}");

