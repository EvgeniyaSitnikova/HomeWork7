// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     double[,] createdArray = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             createdArray[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(0, 100), 1);
//         }
//     }
//     return createdArray;
// }

// void ShowArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }
// double[,] newArray = Create2dArray();
// ShowArray(newArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] Create2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int[,] createdArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             createdArray[i, j] = new Random().Next(0, 100);
//         }
//     }
//     return createdArray;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// void SearchNumber(int[,] array, int i, int j)
// {
//     if (i < array.GetLength(0) & j < (array.GetLength(1)))
//     {
//         Console.WriteLine(array[i - 1, j - 1]);
//     }
//     else
//     {
//         Console.Write("Такого элемента нет ");
//     }
// }

// int[,] newArray = Create2dArray();
// ShowArray(newArray);

// Console.Write("Для поиска элемента введите номер строки: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Для поиска элемента введите номер столбца: ");
// int j = Convert.ToInt32(Console.ReadLine());
// SearchNumber(newArray, i, j);





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] createdArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i, j] = new Random().Next(0, 10);
        }
    }
    return createdArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

double ArithmeticMean(int[,] array)
{
    double sum = 0;
    // int count = 0;
    // double[] arr2 = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            // count++;
            sum = sum + array[j, i];
      
        }
        // sum = sum / count;
        Console.Write($"вторая{sum}");
        // sum = 0;
        // count = 0;
    }

    return sum;
}

int[,] newArray = Create2dArray();
ShowArray(newArray);
double arr2 = ArithmeticMean(newArray);
// Console.WriteLine($"rrrrr{arr2}");














// double t = ArithmeticMean(newArray);
// Console.WriteLine(t);