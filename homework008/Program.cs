/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2


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

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
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
int[,] array = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(array);
SortToLower(array);
Show2dArray(array);


Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void MinLine(int[,] array)
{
int index=0;
int minsum=0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for(int j=0; j<array.GetLength(1); j++) 
    {
        sum+=array[i,j];
    }    
        Console.WriteLine($"Сумма {i} строки = {sum}");
        if(i==0)
        {
            minsum=sum;
        }
        else if (sum<minsum)
        {
            minsum=sum;
            index=i;
        }
      
    }
Console.WriteLine($"Строка с минимальной суммой элементов = {index}");    
}



Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(array);
MinLine(array);

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18


int[,] CreateRandom2dArray(int [,] array, int MinValue, int MaxValue)
{
    for(int i = 0; i < array.GetLength(0); i++)
    
        for(int j = 0; j < array.GetLength(1); j++)
        
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

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.Write("Input a min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = new int[m, n];
CreateRandom2dArray(firstMartrix, minValue, maxValue);
Console.WriteLine($"Первая матрица:");
Show2dArray(firstMartrix);
int[,] secomdMartrix = new int[n, p];
CreateRandom2dArray(secomdMartrix, minValue, maxValue);
Console.WriteLine($"Вторая матрица:");
Show2dArray(secomdMartrix);
int[,] resultMatrix = new int[m,p];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
Show2dArray(resultMatrix);

Зфдача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
*/
Console.WriteLine("Введите число строк и столбцов квадратного двумерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());

int n = x;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}



