//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    System.Console.WriteLine("Введи коректную цифру!");
}
else if (number == 6 || number == 7)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}