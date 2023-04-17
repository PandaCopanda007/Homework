//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Gipot(double x1, double y1, double x2, double y2, double z1, double z2) 
{
    double distX = x2 - x1;
    double distY = y2 - y1;
    double distZ = z2 - z1;
    double result = Math.Sqrt(distX * distX + distY * distY + distZ * distZ);
    return result; 
}

Console.WriteLine("Input coordinates x1 - ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input coordinates x2 - ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input coordinates y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input coordinates y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input coordinates z1 - ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input coordinates z2 - ");
int z2 = Convert.ToInt32(Console.ReadLine());

double rez = Math.Round(Gipot(x1, y1, x2, y2, z1, z2), 2);
Console.WriteLine($"Расстояние между точками 1 и 2 составляет - {rez}");


Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TablKub(int N)
{
    int count = 1;
    while(count <= N) 
    {
        Console.WriteLine($"Куб {count} составляет - {count * count * count}");
        count++;
    }
}

Console.Write("Введите значение - ");
int num = Convert.ToInt32(Console.ReadLine());
TablKub(num);

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом


void Palindrome(int num)
{
	int n = num;
	int tenthousands = num / 10000;
    int units = num % 10;
    int thousands = (num / 1000) % 10;
    int dozens = (num / 10) % 10;
	if(tenthousands == units && thousands == dozens) 
    Console.WriteLine("Палиндром");	
	else 
    Console.WriteLine("Не палиндром");
}
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);

*/
