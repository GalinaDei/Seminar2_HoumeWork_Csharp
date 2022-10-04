// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
void GetThirdFigure (int num)
{
    string str = num.ToString();
    if(num>99)
    {
        Console.Write($"{num} -> ");
        Console.WriteLine(str[2]);
    }
    else
    {
        Console.Write($"{num} -> ");
        Console.WriteLine("третьей цифры нет");
    }
}
GetThirdFigure(4563); 