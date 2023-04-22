// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

bool Palindrom(string s)
{
    for (int i = 0; i < s.Length / 2; i++)

        if (s[i] != s[s.Length - i - 1])
            return false;
    return true;
}

Console.Write("Введите что угодно: ");
string str = Console.ReadLine();
Console.WriteLine(Palindrom(str));