/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

double[,] CreateRandom2dArray(int rows, int columns, double MinValue, double MaxValue)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().NextDouble()* (MaxValue - MinValue) + MinValue;

    return array;    
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
double minValue = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a max value: ");
double maxValue = Convert.ToDouble(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Console.WriteLine($"Сумма диагональных элементов - {DiagSum(myArray)}");

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет


int[,] CreateRandom2dArray(int rows, int columns, int MinValue, int MaxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(MinValue, MaxValue + 1);

    return array;    
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowElement(int[,] array, int a, int b)
{
if (a > array.GetLength(0) || b > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {array[a,b]}");
}
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Console.Write("введите номер строки ");
int a= Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца ");
int b = Convert.ToInt32(Console.ReadLine());
Show2dArray(myArray);
ShowElement(myArray, a, b);


Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int[,] CreateRandom2dArray(int rows, int columns, int MinValue, int MaxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(MinValue, MaxValue + 1);

    return array;    
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void Avarage(int[,] array, int rows, int columns)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(avarage + "; ");
}

}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Avarage(myArray, rows, columns);

