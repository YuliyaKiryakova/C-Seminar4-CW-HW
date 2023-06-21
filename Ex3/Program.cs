/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int num = InputNum("Введите число: ");

// int NumDigit(int num)
// {
//     int i = 0;
//     for (; num != 0; i++)
//     {
//         num /= 10;
//     }
//     return i;
// }

// int ND = NumDigit(num);
// Console.WriteLine($"В этом числе {ND} цифры");

/* еще вариант*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Number(int num)
{
    int res = 0;
    while (num != 0)
    {
        num /= 10;
        res++;
    }
    return res;
}

int number = InputNum("Введите целое число: ");
int result = Number(number);
Console.Write($"Количество цифр в числе: {result}");
