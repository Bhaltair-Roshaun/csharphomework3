// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void PowNumbers(int number)
{
    for (int y = 1; y <= number; y++)
    Console.Write(Math.Pow(y, 3) + ", ");

}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
PowNumbers(number);