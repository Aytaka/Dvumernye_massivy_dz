// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.


// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[,] matrix)
// {
    
//      Console.WriteLine("Введите позицию элемента:");
//      int i = Convert.ToInt32(Console.ReadLine());
//      int j = Convert.ToInt32(Console.ReadLine());

//         if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
//         {
//             Console.WriteLine($"Элемент {matrix[i, j]}");
//         }
//         else
//         {
//             Console.WriteLine($"Элемент с такой позицией не найден.");
//         }
//         Console.WriteLine();
        
// }


// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];

// InputMatrix(matrix);
// PrintMatrix(matrix);
// ReleaseMatrix(matrix);


//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку 
//массива.

// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + "\t");
//         Console.WriteLine();
//     }
// }

// void ChangeArray(int[,] matrix)
// {
    
//     int temporary = 0;
//     for (int i=0; i < matrix.GetLength(1); i++)
//     {
//         temporary = matrix[0, i];
//         matrix[0, i] = matrix[(matrix.GetLength(0) - 1), i];
//         matrix[(matrix.GetLength(0) - 1), i] = temporary;
//      }
// }


// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ChangeArray(matrix);
// PrintMatrix(matrix);

//Задача 3: Задайте  двумерный массив. Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
}


void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}


void GetResult(int[,] matrix)
{
    int position = 0;
    int min = 0;
    int sum = 0;
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    Console.WriteLine(string.Join(", ", array));
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == array.Min()) Console.WriteLine($"\nНаименьшая сумма элементов, находится в {i+1}й строке");
    }
}



Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
GetResult(matrix);
