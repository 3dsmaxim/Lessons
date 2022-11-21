
Console.Clear();


//задача 53 заайте двуменый массив. напишите поамму, 
// которая поменяет местами первую и последнюю строку массива

// void FillMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = (new Random().Next(-11, 11));
//         }
//     }
// }

// void ChengRow(int[,] matrix)
// {
//     int temp = 0;

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         temp = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = temp;

//     }
// }




// void PrintMatrix(int[,] matrix)
// {
//     const int cellWidth = 6;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"|{matrix[i, j],cellWidth:f1}");
//         }
//         Console.Write("|");
//         Console.WriteLine();
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
// ChengRow(matrixFyrst);
// PrintMatrix(matrixFyrst);






// задача 55 Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (new Random().Next(-11, 11));
        }
    }
}

void ChengRow(int[,] matrix)
{
    int temp = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    const int cellWidth = 6;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i, j],cellWidth:f1}");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}




Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите колличество колонок: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrixFyrst = new int[rows, columns];

FillMatrix(matrixFyrst);
PrintMatrix(matrixFyrst);
Console.WriteLine();
Console.WriteLine();


if (matrixFyrst.GetLength(1) != matrixFyrst.GetLength(0))
{
    Console.Write($"невозможно");

}
else
{
    ChengRow(matrixFyrst);
    PrintMatrix(matrixFyrst);
}




//Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных.



//Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении которых расположен 
//наименьший элемент массива.


//Задача 61: Вывести первые N строк треугольника Паскаля. 
//Сделать вывод в виде равнобедренного треугольника







