using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Пример исходного массива
        int[] array = { 1, 1, 2, 2, 2, 3, 4, 4, 4, 4, 5 };
        
        // Преобразование массива
        int[] transformedArray = RemoveLastFromSeries(array);
        
        // Вывод результата
        Console.WriteLine("Преобразованный массив:");
        Console.WriteLine(string.Join(", ", transformedArray));
    }

    static int[] RemoveLastFromSeries(int[] array)
    {
        List<int> result = new List<int>();
        int count = 1; // Счетчик для текущей серии

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                count++; // Увеличиваем счетчик, если элемент такой же
            }
            else
            {
                // Если серия больше 1, добавляем все элементы, кроме последнего
                if (count > 1)
                {
                    for (int j = 0; j < count - 1; j++)
                    {
                        result.Add(array[i - 1]);
                    }
                }
                // Сбрасываем счетчик для новой серии
                count = 1;
            }
        }

        // Обработка последней серии
        if (count > 1)
        {
            for (int j = 0; j < count - 1; j++)
            {
                result.Add(array[array.Length - 1]);
            }
        }

        return result.ToArray();
    }
}
