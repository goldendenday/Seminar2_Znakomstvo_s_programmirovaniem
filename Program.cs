// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100);

Random rand = new Random();
int randNumber = rand.Next(10, 100); // [10, 100)  (10, 11, 12 ... 98, 99)

System.Console.WriteLine(randNumber);
int leftNumber = randNumber / 10;
int rightNumber = randNumber % 10;

if (leftNumber > rightNumber)
{
    System.Console.WriteLine($"Левая цифра больше -> {leftNumber}");
}
else if (rightNumber >= leftNumber)
{
    System.Console.WriteLine($"Правая цифра больше -> {rightNumber}");
}
else
{
    System.Console.WriteLine("Числа равны");
}