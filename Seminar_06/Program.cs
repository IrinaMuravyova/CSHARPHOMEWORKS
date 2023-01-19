/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */
/* 
Console.Clear();

Console.Write("How much numbes are you going enter? (input count)");
int count = Convert.ToInt32(Console.ReadLine());
if (count <= 0) Environment.Exit(0);
int countOfPositive = 0;
for (int i = 0; i < count; i++)
{
    Console.Write("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) countOfPositive ++;
}
Console.WriteLine("");
Console.WriteLine($"Count of positive numbers is: {countOfPositive}"); 
*/

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/* void FindCrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Point of intersection has coordinates: x = {Math.Round(x,2)}, y = {Math.Round(y,2)}");
}

Console.Clear();
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

FindCrossPoint(k1, b1, k2, b2);
 */
