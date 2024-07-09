using System;
using System.Data;
using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {

        Console.Write(" Введите количество строк матрицы: ");
        var rows = int.Parse(Console.ReadLine());
        Console.Write(" Введите количество столбцов матрицы: ");
        var columns = int.Parse(Console.ReadLine());
        int[,] array = new int[rows, columns];


        Console.WriteLine(" Введите элементы в таблицу: ");


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($" Элемент [{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.Clear();
        Console.Write(" Ваш массив: ");

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < columns; j++)
            {

                Console.Write(" {0} ", array[i, j]);
            }
        }
        Console.WriteLine("\n Выберите действие:" +
            "\n1 - Найти количество положительных чисел в матрице: " +
            "\n2 - Найти количество отрицательных чисел в матрице: " +
            "\n3 - Сортировка элементов матрицы построчно  (в двух направлениях): " +
            "\n4 - Инверсия элементов матрицы построчно: ");


        var operation = int.Parse(Console.ReadLine());
        switch (operation)
        {
            case 1:
                Console.Write("положительные числа: ");
                int countPositive = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (array[i, j] > 0)
                        {
                            Console.Write(" {0} ", array[i, j]);
                            countPositive++;
                        }
                    }
                }

                Console.WriteLine("\nКоличество положительных чисел: " + countPositive);
                break;

            case 2:
                Console.Write("отритцательные числа: ");
                int countNegative = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (array[i, j] < 0)
                        {
                            Console.Write(" {0} ", array[i, j]);
                            countNegative++;
                        }
                    }
                }

                Console.WriteLine("\nКоличество отрицательных чисел: " + countNegative);
                break;

            case 3:
                Console.WriteLine("Сортировка элементов матрицы построчно ");


                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("To countinue press any key!");
                Console.ReadKey();
                Console.WriteLine();
                break;

            case 4:

                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                        {
                            if (array[i, k] > array[i, k + 1])
                            {
                                int t = array[i, k];
                                array[i, k] = array[i, k + 1];
                                array[i, k + 1] = t;
                            }
                        }
                    }
                }
                Console.WriteLine("Сортировка элементов матрицы построчно (по возрастанию)");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("To countinue press any key!");
                Console.ReadKey();
                Console.WriteLine();
                break;

            case 5:

                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int str = array.GetLength(1) / 2;

                    for (int j = 0; j < str; j++)
                    {

                        int temp = array[i, j];
                        array[i, j] = array[i, array.GetLength(1) - 1 - j];
                        array[i, array.GetLength(1) - 1 - j] = temp;

                    }
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                break;

        }
    }
}







/*
Console.Write("Введите колличество чисел: ");
        int n = int.Parse(Console.ReadLine());
int countNegativ = 0;
        for (int i = 0; i<n; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            int x = int.Parse(Console.ReadLine());
            if (x< 0)
                countNegativ++;
        }
        Console.WriteLine($"Отритцательных чисел: {countNegativ}");


Console.Write("Введите колличество чисел: ");
int t = int.Parse(Console.ReadLine());
int countPositive = 0;
for (int i = 0; i > n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    if (x > 0)
        countPositive++;
}
Console.WriteLine($"Положительных чисел: {countPositive}");*/











