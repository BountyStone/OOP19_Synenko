using System;

class Program
{
    static void Main(string[] args)
    {
        int k = 456; // Трьохзначне число

        // Отримання цифр числа k
        int c2 = k % 10; // Остання цифра
        int c1 = (k / 10) % 10; // Середня цифра
        int c0 = (k / 100) % 10; // Перша цифра

        // Виведення отриманих цифр
        Console.WriteLine("Лiва цифра: " + c0);
        Console.WriteLine("Середня цифра: " + c1);
        Console.WriteLine("Права цифра: " + c2);

        Console.ReadLine();
    }
}
