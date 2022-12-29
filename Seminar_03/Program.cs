// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
void Palindrom (int number)
{
    int del1 = 1, del2 = 10, del3 = 1;
    int countOfDigit = 1, count = 1;
    while (number/del1>9 || number/del1<-9)
    {
        del1 = del1*10;
        countOfDigit++;
    };
    while ((count<countOfDigit/2) || (count == (countOfDigit/2))) 
    {
     if ((number/del1)%(del2/del3) == (number%del2)/del3) 
        {
        del1 = del1 / 10;
        del2 = del2 * 10;
        del3 = del3 * 10;
        if (count==countOfDigit/2 ) Console.WriteLine("Это палиндром? - да.");
        }   
    else 
    {
        Console.WriteLine("Это палиндром? - нет.");
        break;
    };
    count++;
    };
};

Console.Clear();
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Distance3D (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result;
return result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)) ;
};

Console.Clear();
Console.WriteLine("Введите координаты первой точки (x, y, z): ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Введите координаты второй точки (x, y, z): ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Расстояние между точками: " + Distance3D(x1,y1,z1,x2,y2,z2));
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void Cubes (int n)
{
    int count = 1;
    Console.WriteLine("Кубы чисел от 1 до " + n + ": ");
    while (count < (n + 1)) {
        Console.Write(Math.Pow(count,3) + " ");
        count++;
    };
    Console.WriteLine("");
};
Console.Clear();
Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Cubes(n);
*/