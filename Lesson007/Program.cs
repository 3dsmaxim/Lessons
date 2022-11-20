Console.Clear();

// foreach(var item in array)

// Задача 46: задайте двумерный массив размером [m n] 
// заполните случайными целыми числами

// Console.WriteLine("Введите массив размером [m, n]");
// int[,] matrix = MatrixEter(Console.ReadLine());
// Console.WriteLine($"Двумерный мвссив");
// PrintMatrix(matrix);

// int[,] MatrixEter(string array)
// {
//     string[] arrayEnter = array.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     int[,] matrixTwo = new int[int.Parse(arrayEnter[0]), int.Parse(arrayEnter[1])];
//     for (int i = 0; i < matrixTwo.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixTwo.GetLength(1); j++)
//         {
//             matrixTwo[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return matrixTwo;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"|{array[i, j]}|");
//         }
//         Console.WriteLine();
//     }
// }



// Задача 48: Задайте двуьерный массив размером m на n,
// каждый элемент массива находится по формуле Amn=m+n.


// void FillMatrix(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = i + j;
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($" {matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите колличество колонок: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] matrixFerst = new int[rows, columns];
// FillMatrix(matrixFerst);
// PrintMatrix(matrixFerst);








// Задача 49: Задайте двумерный массив. Найдите, элементы, 
// у которых оба индекса четные, и замените эти элементы на их квадрат.


// void FillMatrix(int[,] resalt)
// {
//     for (int i = 0; i < resalt.GetLength(0); i++)
//     {
//         for (int j = 0; j < resalt.GetLength(1); j++)
//         {
//             resalt[i, j] = new Random().Next(2, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] resalt)
// {
//     for (int i = 0; i < resalt.GetLength(0); i++)
//     {
//         for (int j = 0; j < resalt.GetLength(1); j++)
//         {
//             Console.Write($" {resalt[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void ReplaceMatrixPositive(int[,] resalt)
// {
//     for (int i = 0; i < resalt.GetLength(0); i++)
//     {
//         for (int j = 0; j < resalt.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 ==0 ) 
//             resalt[i, j] *= resalt[i, j];
//         }

//     }
// }

// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите колличество колонок: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] matrixFyrst = new int[rows, columns];
// FillMatrix(matrixFyrst);
// PrintMatrix(matrixFyrst);
// Console.WriteLine();
// Console.WriteLine();
// ReplaceMatrixPositive(matrixFyrst);
// PrintMatrix(matrixFyrst);


// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов главной диагонали


// void FillMatrix(int[,] resalt)
// {
//     for (int i = 0; i < resalt.GetLength(0); i++)
//     {
//         for (int j = 0; j < resalt.GetLength(1); j++)
//         {
//             resalt[i, j] = new Random().Next(2, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] resalt)
// {
//     for (int i = 0; i < resalt.GetLength(0); i++)
//     {
//         for (int j = 0; j < resalt.GetLength(1); j++)
//         {
//             Console.Write($" {resalt[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SumMatrixDiagonale(int[,] resalt)
// {
//     int sum = resalt[0, 0];
//     Console.Write($"Сумма чисел главной диагонали: {resalt[0, 0]}");
//     for (int i = 1; i < resalt.GetLength(0); i++)
//     {
//         for (int j = 1; j < resalt.GetLength(1); j++)
//         {

//             if (i == j)
//             {
//                 Console.Write($"+ {resalt[i, j]}");
//                 sum = sum + resalt[i, j];
//             }
//         }

//     }
//     Console.Write($" = {sum}");
// }

// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите колличество колонок: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] matrixFyrst = new int[rows, columns];
// FillMatrix(matrixFyrst);
// PrintMatrix(matrixFyrst);
// Console.WriteLine();
// Console.WriteLine();
// SumMatrixDiagonale(matrixFyrst);
