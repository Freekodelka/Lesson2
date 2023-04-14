/*Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает 
вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int number = new Random().Next (99,1000);
Console.WriteLine (number);
int del3 = number /=10;
int del1 = number % 10;
Console.WriteLine(del1);









