// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1000 || number < 100)
{
    System.Console.WriteLine("ОШИБКА!Введи трехзначное");
}
else
{
    System.Console.WriteLine(number%100/10);
}