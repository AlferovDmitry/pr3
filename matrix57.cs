using System;

class Program
{
    static void Main()
    {
        // Задаем размеры матрицы (четные числа)
        int M = 4; // Количество строк
        int N = 4; // Количество столбцов

        // Создаем и заполняем матрицу
        int[,] matrix = new int[M, N];
        Random rand = new Random();
        
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(1, 10); // Заполнение случайными числами от 1 до 9
            }
        }

        // Выводим исходную матрицу
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix, M, N);

        // Меняем местами левую верхнюю и правую нижнюю четверти
        SwapQuadrants(matrix, M, N);

        // Выводим измененную матрицу
        Console.WriteLine("Матрица после замены четвертей:");
        PrintMatrix(matrix, M, N);
    }

    static void SwapQuadrants(int[,] matrix, int M, int N)
    {
        int halfM = M / 2;
        int halfN = N / 2;

        for (int i = 0; i < halfM; i++)
        {
            for (int j = 0; j < halfN; j++)
            {
                // Сохраняем значение из правой нижней четверти
                int temp = matrix[i + halfM, j + halfN];

                // Меняем местами с левой верхней четвертью
                matrix[i + halfM, j + halfN] = matrix[i, j];
                matrix[i, j] = temp;
            }
        }
    }

    static void PrintMatrix(int[,] matrix, int M, int N)
    {
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
