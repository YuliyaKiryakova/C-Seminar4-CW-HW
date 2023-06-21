/*Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
7 -> 28
4 -> 10
8 -> 36*/

int SumFrom1ToA(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i; // sum=sum+i
    }
    //sum-=i sum/=10 sum*=10
    return sum;
}

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите целое число: ");
int sum = SumFrom1ToA(num);
Console.WriteLine($"Сумма числе от 1 до N равна {sum}");

