// 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());  
if (n % 2 == 0) System.Console.WriteLine($"Данное число четное");
if (n % 2 != 0) System.Console.WriteLine($"Данное число не четное");
Console.WriteLine("Hello, World!");
