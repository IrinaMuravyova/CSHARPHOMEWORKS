// Домашняя работа по Рекурсии (семинар 9)

// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/* void ShowNumber(int number)
{
    Console.Write($"{number} ");
    if (number > 1) ShowNumber(number - 1);
}

Console.Write("Input natural number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumber(num);
Console.WriteLine(""); */

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/* int GetSumOfNumbers(int numM, int numN)
{
    if (numM > numN) return numM + GetSumOfNumbers(numM - 1, numN);
    else if (numM < numN) return numM + GetSumOfNumbers(numM + 1, numN);
    else return numM;
}

Console.Write("Input natural number M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input natural number N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{GetSumOfNumbers(number1, number2)}"); */

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/* int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman((m - 1), 1);
    else if (m >= 0 && n >= 0) return Akkerman((m - 1), Akkerman(m, n - 1));
    else return 0;
}

Console.Write("Input number M > 0: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N > 0: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Akkerman = {Akkerman(numberM, numberN)}"); */