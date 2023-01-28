// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Enter posive number: ");
int N = int.Parse(Console.ReadLine()!);
int K = 1;
while (K <= N)
{
    if(K %2 == 0)
    {
        Console.Write($"{K} "); 
    }
        K += 1; 
}
