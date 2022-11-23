Console.Clear();

//задача 53 заайте двуменый массив. напишите поамму,
// которая поменяет местами первую и последнюю строку массива



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

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
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


// if (matrixFyrst.GetLength(1) != matrixFyrst.GetLength(0))
// {
//     Console.Write($"невозможно");

// }
// else
// {
//     ChengRow(matrixFyrst);
//     PrintMatrix(matrixFyrst);
// }




//Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

// void FillMatrix(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     const int cellWidth = 4;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"|{matrix[i, j], cellWidth}");
//         }
//         Console.Write("|");
//         Console.WriteLine();
//     }
// }

// void CheckNumMatrix(int[,] result)
// {
//     int count = 0;
//     int namber = 0;
//     for (namber = 0; namber < 10; namber++)
//     {
//         for (int i = 0; i < result.GetLength(0); i++)
//         {
//             for (int j = 0; j < result.GetLength(1); j++)
//             {
//                 if (namber == result[i, j])
//                 {
//                     count++;
//                 }
//             }
//         }
//         if (count != 0)
//         {
//             Console.Write(namber);
//             Console.WriteLine($" повторяется {count} раз");

//         }
//         count = 0;
//     }

//     Console.WriteLine();
// }

// Console.Write("Введите колличество строк: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите колличество колонок: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] matrixFyrst = new int[rows, columns];

// FillMatrix(matrixFyrst);
// PrintMatrix(matrixFyrst);
// CheckNumMatrix(matrixFyrst);



//Задайте двумерный массив из целых чисел. Напишите программу,
//которая удалит строку и столбец, на пересечении которых расположен
//наименьший элемент массива.

void FillMatrix(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    const int cellWidth = 4;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i, j],cellWidth}");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}

void DeleteCrossMatrix(int[,] result)
{
    int column = 0;
    int row = 0;
    int min = result[0, 0];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {

            if (result[i, j] < min)
            {
                min = result[i, j];
            }
        }
    }
    // Console.WriteLine();
    // Console.WriteLine(min); 
    // Console.WriteLine();
    int[] arreyColumn = new int[result.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (result[i, j] == min)
            {
                arreyColumn[j] = result[i, j];
            }
        }
    }
    //  Console.WriteLine();
    // Console.WriteLine(String.Join("-",arreyColumn)); 
    // Console.WriteLine();
    int[] arreyRow = new int[result.GetLength(0)];
    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            if (result[i, j] == min)
            {
                arreyRow[i] = result[i, j];
            }
        }
    }
    // Console.WriteLine();
    // Console.WriteLine(String.Join("-",arreyRow)); 
    // Console.WriteLine();

    for (int i = 0; i < arreyRow.Length; i++)
    {
        if (arreyRow[i] == min)
            row++;
    }
    for (int i = 0; i < arreyColumn.Length; i++)
    {
        if (arreyColumn[i] == min)
            
            column++;
    }
    // Console.WriteLine();
    // Console.WriteLine(row);
    // Console.WriteLine(column);

    // Console.WriteLine();

    int[,] matrixMin = new int[result.GetLength(0) - row, result.GetLength(1) - column];
    column = 0;
    row = 0;
    // PrintMatrix(matrixMin);
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (arreyRow[i] != min)
        {
               for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (arreyColumn[j] != min)
                    {
                       matrixMin[row, column] = result[i, j];
                
                       column++;
                    }
                }

            row++;
            column = 0;
        }
    
     
        
    }
    Console.WriteLine();
    PrintMatrix(matrixMin);

}

Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите колличество колонок: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrixFyrst = new int[rows, columns];



FillMatrix(matrixFyrst);
PrintMatrix(matrixFyrst);

DeleteCrossMatrix(matrixFyrst);


Console.WriteLine();







//Задача 61: Вывести первые N строк треугольника Паскаля.
//Сделать вывод в виде равнобедренного треугольника
