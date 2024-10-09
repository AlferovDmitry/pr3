using System;

class Program
{
    static void Main()
    {
        // Ввод данных от пользователя
        Console.Write("Введите количество членов геометрической прогрессии N (> 1): ");
        int N = int.Parse(Console.ReadLine());
        
        if (N <= 1)
        {
            Console.WriteLine("N должно быть больше 1.");
            return;
        }

        Console.Write("Введите первый член A: ");
        double A = double.Parse(Console.ReadLine());

        Console.Write("Введите знаменатель D: ");
        double D = double.Parse(Console.ReadLine());

        // Создание массива для хранения членов прогрессии
        double[] progression = new double[N];

        // Заполнение массива
        for (int i = 0; i < N; i++)
        {
            progression[i] = A * Math.Pow(D, i); // Формула для i-го члена прогрессии
        }

        // Вывод массива
        Console.WriteLine("Члены геометрической прогрессии:");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Член {i + 1}: {progression[i]}");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        // Ввод данных от пользователя
        Console.Write("Введите количество членов геометрической прогрессии N (> 1): ");
        int N = int.Parse(Console.ReadLine());
        
        if (N <= 1)
        {
            Console.WriteLine("N должно быть больше 1.");
            return;
        }

        Console.Write("Введите первый член A: ");
        double A = double.Parse(Console.ReadLine());

        Console.Write("Введите знаменатель D: ");
        double D = double.Parse(Console.ReadLine());

        // Создание массива для хранения членов прогрессии
        double[] progression = new double[N];

        // Заполнение массива
        for (int i = 0; i < N; i++)
        {
            progression[i] = A * Math.Pow(D, i); // Формула для i-го члена прогрессии
        }

        // Вывод массива
        Console.WriteLine("Члены геометрической прогрессии:");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Член {i + 1}: {progression[i]}");
        }
    }
}
