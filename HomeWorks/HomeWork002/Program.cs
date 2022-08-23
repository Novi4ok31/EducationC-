
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
/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int FindTreeDigit (int number)
{
    for (int i = 0; i < 3; i++)
    {
        int treeDigit = number %10;
    }   
    return treeDigit;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = FindTreeDigit(number);
if(result > 0)
    Console.WriteLine($"Tree-digit of {number} is {result}");
else 
    Console.WriteLine("There are no third digits");

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным?

bool CheckingHolidays (int number)
{
    if(number == 6 && number == 7)
        return true;
    else 
        return false;
}

Console.Write("Input number of 1 to 7 (Day of week): ");
int n = Convert.ToInt32(Console.ReadLine());
bool result = CheckingHolidays(n);
Console.WriteLine(result);

//Your number is not correct