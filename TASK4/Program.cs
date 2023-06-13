// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да
Console.WriteLine("Введи 1 число");
int first = Convert.ToInt32(Console.ReadLine());

if (first % 7 == 0 && first % 23 == 0)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}