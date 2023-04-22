




int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next (minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i< array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите число начального значения: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите число конечного значения: ");
int max = int.Parse(Console.ReadLine());
int[] array = GenerateArray(length, min, max);