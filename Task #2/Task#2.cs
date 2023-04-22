// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

void XYRange(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double result = Math.Sqrt((Math.Pow((x1 - x2), 2)) + (Math.Pow((y1 - y2), 2)+ (Math.Pow((z1 - z2), 2))));
    Console.WriteLine(result);
}
Console.WriteLine("Введите число x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число z2: ");
double z2 = double.Parse(Console.ReadLine());
XYRange(x1, x2, y1, y2, z1, z2);