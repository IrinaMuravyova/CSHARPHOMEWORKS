// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/* 
int a;
int b;
Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (a > b) Console.WriteLine("Число " + a + " больше числа " + b + ".");
else Console.WriteLine("Число " + b + " больше числа " + a + ".");
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
/*
int a, b, c, max;
Console.WriteLine("Введите три числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("Максимальное число: " + max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
/*
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2==0) Console.WriteLine("Число " + a + " четное.");
else Console.WriteLine("Число " + a + " нечетное.");
*/
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8 */

/*
int x, N;
x = 2;
Console.WriteLine("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());
if (N < 2) Console.WriteLine($"Нет четных чисел больше 1 и меньше N :");
else Console.WriteLine($"Все четные числа от 1 до N :");
while (x < N+1) {
    Console.Write(x + " ");
    x=x+2;
}; 
Console.WriteLine();
*/