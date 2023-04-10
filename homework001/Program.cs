/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.Write("большее число = ");
Console.WriteLine(max);


Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).


Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 % 2 == 0)
{
    Console.WriteLine(+ num1 + "- четное число");
}
else
{
    Console.WriteLine(+ num1 + "- нечетное число");
}


Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.

*/

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 2;

if(num1 > 1)
{
    while(num2 <= num1)
    {
        Console.Write(num2 + " ");
        num2 = num2 + 2;
    }
}



