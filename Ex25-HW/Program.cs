/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Stepen(int A, int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res *= A;
    }
    return res;
}

int A = InputNum("Введите число А: ");
int B = InputNum("Введите число B: ");
int result = Stepen(A, B);
Console.Write(result);
