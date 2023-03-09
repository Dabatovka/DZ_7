// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// 1 4 5 6
// 5 9 2 3
// 8 4 2 4
// 17-> такого элемента нет

Console.WriteLine("Введите номер строки");
int а = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца");
int b = int.Parse(Console.ReadLine()!);
int [,] numbers = new int [10,10];
GetArray(numbers);

if (а > numbers.GetLength(0) || b > numbers.GetLength(1))
{
    Console.WriteLine("Tакого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента строки {а} и столбца {b} равно {numbers[а-1,b-1]}");
}

PrintArray(numbers);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
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
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}