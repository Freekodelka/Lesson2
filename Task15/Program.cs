/*Напишите программу, 
которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
Не много нубски, но по другому я не сообразил*/


int number = new Random().Next (0,10000);
Console.WriteLine (number);

while (number > 999)
{
    number /=10;
}

if (number < 100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else {
    int third_number = number % 10;
    Console.WriteLine (third_number);
}





