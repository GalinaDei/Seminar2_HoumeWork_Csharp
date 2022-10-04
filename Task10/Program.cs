// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
void GetSecondFigure (int num)
{
    string str = num.ToString();
    Console.Write($"{num} -> ");
    Console.WriteLine(str[1]);
    }
GetSecondFigure(678);   