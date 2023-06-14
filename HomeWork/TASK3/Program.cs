// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введи число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
if (number < 1000 && number >=100)
{
    System.Console.WriteLine(number%10);
}
if (number >= 1000 && number < 10000)
{
    System.Console.WriteLine(number%100/10);
}
if (number >= 10000 && number < 100000)
{
    System.Console.WriteLine(number%1000/100);
}
