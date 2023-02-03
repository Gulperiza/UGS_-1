// 2. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Введите число а:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
if(a>b) System.Console.WriteLine($"{a} является наибольшим числом {b} является наименьшим");
if(b>a) System.Console.WriteLine($"{b} является наибольшим числом {a} является наименьшим");
