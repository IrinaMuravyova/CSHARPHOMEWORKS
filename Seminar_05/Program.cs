// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomThreeChartArray(int n)
{
    int[] array = new int[n];
    
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int CountEvenElements(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result ++;
    }
    return result;
}

Console.Write("Enter count of array's elements: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateRandomThreeChartArray(count);
ShowArray(arr);
Console.WriteLine($"Count of even elements: {CountEvenElements(arr)}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int c, int lowValue, int highValue)
{
    int[] array = new int[c];
    for (int i = 0; i < c; i++)
    {
        array[i] = new Random().Next(lowValue, highValue+1);
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

int SumOfNotEvenPositionElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i%2 == 1) sum += arr[i]; // если за нечетную позицию считаем нечетный индекс
        //if (i%2 == 1) sum += arr[i]; // если за нечетную позицию считаем позицию при показе массива
    }
    return sum;
}

Console.Write("Enter count of array's elements: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter low element: ");
int lowValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter high element: ");
int highValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(count, lowValue, highValue);
ShowArray(array);
Console.WriteLine($"Sum of not even elements is { SumOfNotEvenPositionElements(array)}");
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
double[] CreateRandomArray(int c, double lowValue, double highValue)
{
    double[] array = new double[c], array1 = new double[c], array2 = new double[c];

    for (int i = 0; i < c; i++)
    {
        array1[i] = new Random().Next(Convert.ToInt32(lowValue),Convert.ToInt32(highValue));
        array2[i] = new Random().NextDouble();
        array[i] = array1[i] + array2[i];
    }
    return array;
}

void ShowArray(double[] array, int round)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i],round) + " ");
    }
    Console.WriteLine();    
}

double SumMaxAndMinElementsOfArray(double[] arr, int round)
{
    double minElement = arr[0], maxElement = arr[0];
    double different = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>maxElement) maxElement = arr[i];
        if (arr[i]<minElement) minElement = arr[i];
    }
    if (minElement>0 && maxElement>0) 
        different = Math.Round(maxElement - minElement, round); //если и макс и мин положительные
    return different;
}

Console.Write("Enter count of array's elements: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter low element: ");
int lowValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter high element: ");
int highValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Сколько знаков после запятой выводить в элементах: "); // не знаю как по английски написать) только учусь
int round = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomArray(count, lowValue, highValue);
ShowArray(array, round);
Console.WriteLine($"Different between min amd max elements is {SumMaxAndMinElementsOfArray(array, round)}");
*/