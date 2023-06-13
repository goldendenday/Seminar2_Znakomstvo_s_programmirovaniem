//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
int result = new Random().Next(100, 1000);
System.Console.WriteLine(result);
System.Console.WriteLine($"{result / 100}{result % 10}");
