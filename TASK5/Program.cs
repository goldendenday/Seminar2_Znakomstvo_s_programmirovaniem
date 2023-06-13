// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
Console.WriteLine("Введите число А = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Б = ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA==numberB*numberB || numberB==numberA*numberA)
{
    Console.WriteLine("Да,одно из числе является квадратом другого");
}
else
{
    Console.WriteLine("нет ни одно не явлется квадратом другого");
}
