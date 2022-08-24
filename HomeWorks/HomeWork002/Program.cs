
// HomeWork002

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
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
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void FindTreeDigit (int number)
{
    if (-100 < number && number < 100)
    {
        Console.WriteLine($"Number {number} there are not third digits");
    } 
    else if (number <= -100)
        {
            int positiveNumber = number * (-1);
            while (positiveNumber > 999)
            {
                positiveNumber = positiveNumber /10;
            } 
            int ed = positiveNumber %10;
            Console.WriteLine($"Tree-digit of {number} is {ed}");
        }
    else if (number >= 100)
        {
            int currentNumber = number;
            while (currentNumber > 999)
            {
                currentNumber = currentNumber /10;
            }
            int ed = currentNumber %10;
            Console.WriteLine($"Tree-digit of {number} is {ed}");
        } 
}

Console.Write("Input a number: ");
int result = Convert.ToInt32(Console.ReadLine());
FindTreeDigit(result);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным?
/*
bool CheckingHolidays (int number)
{
    if(number == 6 || number == 7)
        return true;
    else 
        return false;
}

Console.Write("Input day of week (number of 1 to 7): ");
int n = Convert.ToInt32(Console.ReadLine());
bool result = CheckingHolidays(n);
Console.WriteLine($"{n} -> {result}");
*/
// Вариант 2 - не работает
/*
Console.Write("Input day of week (number of 1 to 7): ");
int n = Convert.ToInt32(Console.ReadLine());
if(n>0 && n<=7)
    bool result = CheckingHolidays(n);
    Console.WriteLine($"{n} -> {result}");
else
    Console.WriteLine("Your number is not correct");
*/
