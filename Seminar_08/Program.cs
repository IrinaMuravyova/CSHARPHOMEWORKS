// Домашняя работа к семинару 8 по двумерным массивам

/* Задача 54 (ОК): Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
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

void ReductionInRowsOfArray(int[,] array) // сортировка внутри строки по убыванию
{
    for (int k = array.GetLength(1) - 1; k > 0; k--)
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < k; j++)
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
ReductionInRowsOfArray(newArray);
Show2dArray(newArray);
 */
/* Задача 56 (OK): Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
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

int FindMinSumInRow(int[,] array)
{
    int minSum = 0, minSumI = 0;
    for (int i = 0, j = 0; j < array.GetLength(1); j++) 
        minSum = minSum + array[i, j]; // чтобы было с чем сравнивать, считаю сумму первой строки

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
        if (sum < minSum)
        {
            minSum = sum;
            minSumI = i;
        }
    }
    return minSumI;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.WriteLine($"Min summ in row number {FindMinSumInRow(newArray)}"); */

/* Задача 58 (OK): Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
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

// статически задаю изначальные матрицы, чтобы проверить по примеру из задачи
// закоментировать строки 206-207 для отработки на случайных матрицах
int[,] array1 = { { 2, 4 }, { 3, 2 } };
int[,] array2 = { { 3, 4 }, { 3, 3 } };

int[,] ProisvedenieOfMatrix(int[,] array1, int[,] array2)
{
    int[,] arrayResult = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {

        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                arrayResult[i, j] = 0;
                for (int m = 0; m < array1.GetLength(1); m++)
                    arrayResult[i, j] += array1[i, m] * array2[m, j];
            }
    }
    else Console.WriteLine($"Umnozhenie can not be calculate");
    return arrayResult;
}

Show2dArray(ProisvedenieOfMatrix(array1, array2));
//раскомментировать ниже, если хочется отработать на случайных матрицах
// int [,] array1 = CreateRandom2dArray();
// int [,] array2 = CreateRandom2dArray();
// Show2dArray(array1);
// Show2dArray(array2);
// Show2dArray(ProisvedenieOfMatrix(array1, array2)); */

/* Задача 60 (OK). ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
/* 
int[,,] Create3DRandomUniqueArray()
{
    Console.Write("Input a count of elements in first dimension: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a count of elements in second dimension: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a count of elements in thirth dimension: ");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimum value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int[x, y, z];
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
            {
                CHANGEVALUE:
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
              
                for (int ii = array.GetLength(0)-1; ii >= 0; ii--)
                    for (int jj = array.GetLength(1)-1; jj >= 0; jj--)
                        for (int kk = array.GetLength(2)-1; kk >= 0; kk--)
                        {
                            if (i == ii && j == jj && k == kk) continue;
                            if (array[ii, jj, kk] == array[i, j, k]) goto CHANGEVALUE;
                        };
            };
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(string.Format("{0:d2}", array[i, j, k]) 
                    + $"({i},{j},{k}) "); //чтобы числа по 99 выводились ровненько столбцами
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] newArray = Create3DRandomUniqueArray();
Show3dArray(newArray); */


/* Задача 62(OK). Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
/* 
void Show2dArray2Char(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(string.Format("{0:d2}", array[i, j]) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FullSpiralArray(int[,] array)
{
    int lineTop = 0,
        lineRight = array.GetLength(1) - 1,
        lineBottom = array.GetLength(0) - 1,
        lineLeft = 0;

    while (lineRight >= lineLeft || lineBottom >= lineTop)
    {
        // меняю верхнюю границу
        for (int i = 0; i < lineRight + 1; i++)
            if (i == lineTop)
                for (int j = lineLeft; j < lineBottom + 1; j++)
                    if (i == 0 && j == 0) array[i, j] = 1;
                    else array[i, j] = array[i, j - 1] + 1;
        lineTop += 1;

        // меняю правую границу
        for (int j = 0; j < lineRight + 1; j++)
            if (j == lineRight)
                for (int i = lineTop; i < lineBottom + 1; i++)
                    array[i, j] = array[i - 1, j] + 1;
        lineRight -= 1;

        // меняю нижнюю границу
        for (int i = 0; i < lineBottom + 1; i++)
            if (i == lineBottom)
                for (int j = lineRight; j >= lineLeft; j--)
                    array[i, j] = array[i, j + 1] + 1;
        lineBottom -= 1;

        // меняю левую границу
        for (int j = lineLeft; j < lineRight + 1; j++)
            if (j == lineLeft)
                for (int i = lineBottom; i > lineTop - 1; i--)
                    array[i, j] = array[i + 1, j] + 1;
        lineLeft += 1;
    }
}

int[,] newArray = new int[4, 4];
Console.WriteLine("");
Show2dArray2Char(newArray);
FullSpiralArray(newArray);
Show2dArray2Char(newArray); */