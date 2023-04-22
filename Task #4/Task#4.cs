// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int MathPow(int a, int b)
{
    int temp2 = a;
    if (b == 0)
    {
        a = 1;
    }
    else
    {
        for (int temp = 0; temp < b - 1; temp++)
        {
            a = a * temp2;
        }
    }
    return a;
}
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("A в степени B = " + MathPow(a, b));

