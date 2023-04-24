/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2


int [] CreateArray(int size, int min,  int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    
    return array;

}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();

}

int EvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) 
           
          count++;
                    
    }
    return count;
}

Console.Write("Input a quantity of elements ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, 100, 1000);
ShowArray(array);
Console.WriteLine("Quntity of even elements is " + EvenNumber(array));

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] CreateArray(int size, int min,  int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    
    return array;

}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();

}

int SumOfOdd(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i ++)
    {
       if(i % 2 != 0)
       sum += array[i];
    }
return sum;
}

Console.Write("Input a quantity of elements ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size, min, max);
ShowArray(array);
int sum = SumOfOdd(array);
Console.WriteLine($"Sum of odd elements is {sum}" );

*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double [] CreateArray(int size, double min, double max)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().NextDouble() * (max - min) + min;
        return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();

}


double DifMaxMin (double [] array)
{
   Console.WriteLine("Minimum number is " + array.Min());
   Console.WriteLine("Maximum number is " + array.Max());
   double rez = array.Max() - array.Min();
   return rez;
}

Console.Write("Input a quantity of elements ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size, min, max);
ShowArray(array);
Console.WriteLine($"Difference is " + (DifMaxMin(array)));
