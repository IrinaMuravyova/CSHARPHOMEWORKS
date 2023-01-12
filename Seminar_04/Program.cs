// Домашнее задание к семинару 4

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int Involution (int num1, int num2)
{
    int res = 1;
    int i = 1;
    while (i <= num2) //for (i = 1; i <= num2; i++)
    {
        res *= num1;
        i++;
    }
    return res;
}

Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter natural number (degree): ");
int b = Convert.ToInt32(Console.ReadLine());
int res = Involution(a,b);
Console.WriteLine($"{a} in degree {b} is {res}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SumOfDigit(int num)
{
    int size = 0;
    int num1 = num;   // сохраняю значение num в первоначальном виде
    while ( num > 0 ) // определяю кол-во цифр
    {
        num = num/10;
        size ++;
    }


    int[] array = new int[size];
    int sumOfDigit = 0;
    int i = 0;

    for (i = 0; i < size; i++)
    {
        array[i] = num1%10; 
        num1 = num1/10;
        sumOfDigit += array[i];
    }
    return sumOfDigit;
}

Console.Write("Enter number: ");
int num  = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigit(num);
Console.WriteLine($"Sum of digits for number {num} is {result}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] CreateArray(int size)
{
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter element of array: ");
        array[i] =  Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();    
}

Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
*/