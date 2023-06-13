// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
System.Console.WriteLine("Введите первое число ");
System.Console.WriteLine("Введите второе число ");
int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());

if(first % second == 0){
    System.Console.WriteLine("Число является кратным второму");
}
else{
    System.Console.WriteLine($"Число не является кртаным и остаток от деления {first%second}");
}
