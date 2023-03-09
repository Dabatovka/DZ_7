// 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифмитическое в каждом столбце.
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4
// Среднее арифмитическое  каждого столбца: 4,6/5,6/3,6/3 

Console.WriteLine("Введите количество строк");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int b = int.Parse(Console.ReadLine()!);

int[,] numbers = new int[a, b];
GetArray(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double num = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        num = (num + numbers[i, j]);
    }
    num = num / a;
    Console.Write(num + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}