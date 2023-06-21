/* Напишите программу, которая задаёт массив из 8 элементов (случайно выбранных из заданного интервала) и выводит их на экран.
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] Massive(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write(" [");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("] ");
}

int len = InputNum("Введите длину массива: ");
int start = InputNum("Введите начальное значение: ");
int end = InputNum("Введите конечное значение: ");
int[] arr = Massive(len, start, end);
PrintArray(arr);
