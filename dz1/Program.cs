// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("введите количество строк");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int count = Convert.ToInt32(Console.ReadLine());

double[,] a = new double [length, count];

Random random = new Random();
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < count ; j++)
    {
        a[i, j] = random.NextDouble() * 10;
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}   
