/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.*/

Console.WriteLine("Введите день недели");

int N = int.Parse(Console.ReadLine());

if (N == 1)
{
Console.WriteLine ("Monday - this is work day");
}

if (N == 2)
{
Console.WriteLine ("Tusday - this is work day");
}

if (N == 3)
{
Console.WriteLine ("Wednesday - this is work day");
}

if (N == 4)
{
Console.WriteLine ("Thusday - this is work day");
}

if (N == 5)
{
Console.WriteLine ("Friday - this is work day");
}

if (N == 6)
{
Console.WriteLine ("Saturday - this is weekend");
}

if (N == 7)
{
Console.WriteLine ("Sunday - this is weekend");
}

if (N > 7) 
{
Console.WriteLine ("there is no such day of the week");
}
