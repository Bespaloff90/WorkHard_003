// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Enter your number:  ");
int number = Convert.ToInt32(Console.ReadLine());
int even = 1;
// even <= number; even++)
while (even <= number)

{ 

    if (even % 2 == 0)
    {
        Console.WriteLine(even);
        
    }

even++;
}

