// Семинар №3
// Задача 1 . Принимает на вход координаты точки отличные от нуля и выдает номер четверти, в которой находится эта точка
/*
double FindQuart(double x, double y)
{
    if(x>0 && y>0) return 1;
    if(x<0 && y>0) return 2;
    if(x<0 && y<0) return 3;
    if(x>0 && y<0) return 4;

    return 0;
}

Console.Write("Input first number: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
double yA = Convert.ToInt32(Console.ReadLine());

double quartNum = FindQuart(xA,yA);

if (quartNum == 0) 
    Console.WriteLine("Point on the axes!");
else
    Console.WriteLine($"Point is located on {quartNum} quart.");
*/

// Программа, которая по заданному номеру четверти показывает диапозон возможных координат точек в этой четверти (x,y)

void FindPoint(int quart)
{
    if(quart == 1) Console.WriteLine("Диапозон возможных координат (x>0,y>0)");
    if(quart == 2) Console.WriteLine("Диапозон возможных координат (x<0,y>0)");
    if(quart == 3) Console.WriteLine("Диапозон возможных координат (x<0,y<0)");
    if(quart == 4) Console.WriteLine("Диапозон возможных координат (x>0,y<0)");
}

Console.Write("Input number of quart: ");
int quart = Convert.ToInt32(Console.ReadLine());
FindPoint(quart);

   