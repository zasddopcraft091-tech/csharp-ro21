using System;

class Program
{
    static void Main()
    {
        int number = 2026;
        int temp = number;
        int sum = 0;
        int count = 0;

        if (temp == 0)
            count = 1;

        while (temp > 0)
        {
            sum += temp % 10;
            count++;
            temp /= 10;
        }

        Console.WriteLine($"Число: {number}");
        Console.WriteLine($"Количество цифр: {count}");
        Console.WriteLine($"Сумма цифр: {sum}");
    }
}
