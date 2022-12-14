// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
/*
void Numbers(int m, int n) 
{
    int min = m;
    if(m < n) Numbers(m, n - 1);
    Console.Write(n + " ");
}
Numbers(5, 20);
*/
/*
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

void Numbers(int m, int n) 
{
    int min = m;
    if(m < n) Numbers(m, n - 1);
    Console.Write(n + " ");
}
Numbers(5, 10);

int SumNumbers(int m, int n) 
{
    if (m!=n)
    {
        if (m>n) 
            return m + SumNumbers(n, m-1);
        else
            return n + SumNumbers(m, n-1);
    }
    else
    {
        return m;
    }
}

Console.WriteLine(" ");
Console.WriteLine(SumNumbers(5,10));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Ackerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return Ackerman(m - 1, 1);      
    if(m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    else
        {
            Console.WriteLine("Check first and second number. They must be non-negative");
            return 0;
        }
}
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Ackerman(a, b);
Console.WriteLine($"The ackerman function is {result}");
