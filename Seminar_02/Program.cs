// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int SecondNumber (int number)
{
int result = (number%100)/10;
return result;
}

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/1000>0||number%1000<0) Console.WriteLine("Вы ввели не трехзначное число )");
else Console.WriteLine("Вторая цифра введенного числа равна " + SecondNumber(number));
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
int ThirdNumber(int number)
{
int delitel = 10;
while (number/delitel<0 || number/delitel>0)
{
    delitel = delitel*10;
};
int result = (number/(delitel/1000))%10;
return result;
};
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 == 0) Console.WriteLine("третьей цифры нет");
else Console.WriteLine("Третяя цифра числа: " + ThirdNumber(number));
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
/*
void Weekend (int day)
{
    if (day == 6 || day == 7) Console.WriteLine("да");
    else Console.WriteLine("нет");
};
Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("Этот день выходной? - ");
Weekend(day);
*/