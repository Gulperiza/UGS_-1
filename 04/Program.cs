// 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число c:");
int c = Convert.ToInt32(Console.ReadLine());;
int max = a;
if(b>max) max = b;
if(c>max) max = c;
System.Console.WriteLine($"Максимальное число {max}");
