using System;

class Program
{
    static void Main()
    {
        // Задаем значения M и N
        int M = 3; // Количество строк
        int N = 5; // Количество чисел в наборе

        // Задаем набор чисел
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Создаем матрицу размером M x N
        int[,] matrix = new int[M, N];

        // Заполняем матрицу
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = numbers[j];
            }
        }

        // Выводим матрицу на экран
        Console.WriteLine("Сформированная матрица:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
