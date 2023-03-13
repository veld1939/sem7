// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество строк");
int arr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int arr2 = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[arr, arr2];
Numbers(numbers);

void Numbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
      
        Console.WriteLine("");
    }
}
Console.WriteLine();
Print(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double count = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        count = (count + numbers[i, j]);
    }
    count = count / arr;
    Console.Write(count + "  ");
}
