//Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:  ");
int b = Convert.ToInt32(Console.ReadLine());
if( a > b)
{
    Console.WriteLine("first number > second number");

}
if (b > a)

{
    Console.WriteLine("second number > first number");
}