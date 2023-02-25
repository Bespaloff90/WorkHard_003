// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Hello!");
Console.WriteLine("Enter First numbers:     ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second number:      ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Three number:        ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max)  max = b;
if (c > max)  max = c;

Console.Write(max);

