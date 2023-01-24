// Homework to Seminar 7. 2dArray

/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

/* double[,] CreateRandom2dDoubleArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimum value: ");
    double minValue = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a maximum value: ");
    double maxValue = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue + 1)) +
                new Random().NextDouble();
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{Math.Round(array[i,j],2)} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] newArray = CreateRandom2dDoubleArray();
Show2dArray(newArray);
 */

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет */
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimum value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


void GetElementArrayOnPosition (int[,] array, int rowid, int columnid) // вариант через войдовский метод
{
     if (rowid < array.GetLength(0) && columnid < array.GetLength(1)) 
         Console.WriteLine($"Element with index row = {rowid} and index column = {columnid} is {array[rowid,columnid]}");
         else Console.Write($"Element with index row = {rowid} and index column = {columnid} is not exist");
 } 

int[,] newArray = CreateRandom2dArray();
Console.Write("Input number of row for find element:");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of column for find element:");
int c = Convert.ToInt32(Console.ReadLine());
Show2dArray(newArray);
GetElementArrayOnPosition(newArray, r, c);  */

// вариант возвращать int и сообщение - не рабочий вариант
// очень хочу сделать, чтобы метод именно возвращал значение
// компилятор просит чтобы в случае с else тоже был какой-то return. Как-то можно обойти?
/*
int GetElementArrayOnPosition(int[,] array, int rowid, int columnid)
{
    if (rowid < array.GetLength(0) && columnid < array.GetLength(1))
        return array[rowid, columnid];
    else Console.WriteLine($"Element with index row = {rowid} and index column = {columnid} is not exist");
}

int[,] newArray = CreateRandom2dArray();
Console.Write("Input number of row for find element:");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of column for find element:");
int c = Convert.ToInt32(Console.ReadLine());
Show2dArray(newArray);
Console.WriteLine($"Element with index row = {r} and index column = {c} is {GetElementArrayOnPosition(newArray, r, c)}");
*/

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
/* 
double[,] CreateRandom2dDoubleArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimum value: ");
    double minValue = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a maximum value: ");
    double maxValue = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue + 1)) +
                new Random().NextDouble();
    return array;
}

// double[,] newArray= new double [,] // фиксированный массив на вход для проверки по примеру задачи
// {
// {1,4,7,2},
// {5,9,2,3},
// {8,4,2,4},
// };

void Show2dDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{Math.Round(array[i,j],2)} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] AverageColumbs(double[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];
    for (int j=0; j<array.GetLength(1);j++)
    {
        for (int i = 0; i< array.GetLength(0);i++)
            averageArray[j] +=  array[i,j];
        averageArray[j] = averageArray[j]/array.GetLength(0);
    }
    return averageArray;
}

void ShowArray(double[] array, int round)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i],round) + " ");
    }
    Console.WriteLine();    
}

double[,] newArray = CreateRandom2dDoubleArray();
Show2dDoubleArray(newArray);
ShowArray(AverageColumbs(newArray),2);
 */