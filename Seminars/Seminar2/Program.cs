/*
// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.

int FindBiggestDigit(int number)
{
    int ed = number %10;
    int dec = number/10;
    int max;

    if (ed > dec)
        max = ed;
    else
        max = dec;
    return max;
}

int randomNumber = new Random().Next(10,100);
// Генерирует случайное число. 
int biggestDigit = FindBiggestDigit(randomNumber);
Console.WriteLine ($"Biggest digit of {randomNumber} is {biggestDigit}");
*/



/*
// Задача 2. Выводит случайное трехзначное число и удаляет вторую цифру 

int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    return sot * 10 + ed;
}

int randomNumber = new Random().Next(100,1000);
int newNumber = CutNumber(randomNumber);
Console.WriteLine ($"New version of {randomNumber} is {newNumber}");

*/

/*
// Задача3. Напишите программу, которая будет принимать на вход два числа и выводить является ли второе число

void IsDivisionable(int num1, int num2)
{
    int reminder = num2 % num1;
    if( reminder == 0)
        Console.WriteLine($"{num2} is divisionable of {num1}");
    else
        Console.WriteLine($"{num2} is not divisionable of {num1}. Reminder is {reminder}");
}

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

IsDivisionable(n1, n2);
*/

// Задача 4. Принимает на вход число и проверяет кратно ли оно одновременно двум числам 7 и 21
/*
bool IsDivis(int number)
{
    if(number %7 == 0 && number %23 == 0)
        return true;
    else
        return false;
}
*/
bool IsDivis(int number)
{
    return number %7 == 0 && number %23 == 0;
   
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

bool IsDivision =IsDivis(n);
Console.WriteLine(IsDivision);
