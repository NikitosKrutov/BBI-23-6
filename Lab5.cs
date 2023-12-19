using System;

class Program
{
    //3
    //static void Main()
    //{
    //    int[,] B = GenerateRandomMatrix(5, 5);
    //    int[,] C = GenerateRandomMatrix(6, 6);

    //    Console.WriteLine("Исходная матрица B:");
    //    PrintMatrix(B);

    //    Console.WriteLine("\nИсходная матрица C:");
    //    PrintMatrix(C);

    //    B = RemoveRowWithMaxDiagonalElement(B);
    //    C = RemoveRowWithMaxDiagonalElement(C);

    //    Console.WriteLine("\nМатрица B после удаления строки с максимальным элементом на диагонали:");
    //    PrintMatrix(B);

    //    Console.WriteLine("\nМатрица C после удаления строки с максимальным элементом на диагонали:");
    //    PrintMatrix(C);
    //}

    //static int[,] GenerateRandomMatrix(int rows, int cols)
    //{
    //    Random random = new Random();
    //    int[,] matrix = new int[rows, cols];

    //    for (int i = 0; i < rows; i++)
    //    {
    //        for (int j = 0; j < cols; j++)
    //        {
    //            matrix[i, j] = random.Next(1, 100);
    //        }
    //    }

    //    return matrix;
    //}

    //static int[,] RemoveRowWithMaxDiagonalElement(int[,] matrix)
    //{
    //    int maxElement = matrix[0, 0];
    //    int maxRowIndex = 0;

    //    for (int i = 1; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); i++)
    //    {
    //        if (matrix[i, i] > maxElement)
    //        {
    //            maxElement = matrix[i, i];
    //            maxRowIndex = i;
    //        }
    //    }

    //    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];

    //    for (int i = 0, newRow = 0; i < matrix.GetLength(0); i++)
    //    {
    //        if (i != maxRowIndex)
    //        {
    //            for (int j = 0; j < matrix.GetLength(1); j++)
    //            {
    //                newMatrix[newRow, j] = matrix[i, j];
    //            }
    //            newRow++;
    //        }
    //    }

    //    return newMatrix;
    //}

    //static void PrintMatrix(int[,] matrix)
    //{
    //    for (int i = 0; i < matrix.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < matrix.GetLength(1); j++)
    //        {
    //            Console.Write(matrix[i, j] + "\t");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //9
    //static void Main()
    //{
    //    int[,] matrixA = GenerateRandomMatrix(6, 5);
    //    int[,] matrixC = GenerateRandomMatrix(7, 4);

    //    int[] resultArray = CombineArrays(matrixA, matrixC);

    //    Console.WriteLine("Матрица A:");
    //    PrintMatrix(matrixA);

    //    Console.WriteLine("\nМатрица C:");
    //    PrintMatrix(matrixC);

    //    Console.WriteLine("\nРезультат объединения массивов:");
    //    foreach (int value in resultArray)
    //    {
    //        Console.Write(value + " ");
    //    }

    //    Console.ReadLine();
    //}

    //static int[,] GenerateRandomMatrix(int rows, int cols)
    //{
    //    int[,] matrix = new int[rows, cols];
    //    Random random = new Random();

    //    for (int i = 0; i < rows; i++)
    //    {
    //        for (int j = 0; j < cols; j++)
    //        {
    //            matrix[i, j] = random.Next(-50, 51);
    //        }
    //    }

    //    return matrix;
    //}

    //static void PrintMatrix(int[,] matrix)
    //{
    //    for (int i = 0; i < matrix.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < matrix.GetLength(1); j++)
    //        {
    //            Console.Write(matrix[i, j] + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    //static int[] CombineArrays(int[,] matrixA, int[,] matrixC)
    //{
    //    int[] sumArrayA = CalculateColumnSums(matrixA);
    //    int[] sumArrayC = CalculateColumnSums(matrixC);
    //    int[] resultArray = new int[sumArrayA.Length + sumArrayC.Length];
    //    sumArrayA.CopyTo(resultArray, 0);
    //    sumArrayC.CopyTo(resultArray, sumArrayA.Length);

    //    return resultArray;
    //}

    //static int[] CalculateColumnSums(int[,] matrix)
    //{
    //    int[] sums = new int[matrix.GetLength(1)];

    //    for (int i = 0; i < matrix.GetLength(1); i++)
    //    {
    //        int sum = 0;
    //        for (int j = 0; j < matrix.GetLength(0); j++)
    //        {
    //            if (matrix[j, i] > 0)
    //            {
    //                sum += matrix[j, i];
    //            }
    //        }
    //        sums[i] = sum;
    //    }

    //    return sums;
    //}

    //15
    //static void Main()
    //{
    //    int[,] matrix1 = {
    //    {5, 2, 8},
    //    {1, 7, 4},
    //    {3, 6, 9}
    //};

    //    int[,] matrix2 = {
    //    {70, 90}
    //};

    //    int[,] matrix3 = {
    //    {2, 6, 5}
    //};

    //    double[] averages = new double[3];

    //    averages[0] = CalculateAverageWithoutMinMax(matrix1);
    //    averages[1] = CalculateAverageWithoutMinMax(matrix2);
    //    averages[2] = CalculateAverageWithoutMinMax(matrix3);

    //    Console.WriteLine("Средние значения элементов матриц:");
    //    PrintArray(averages);

    //    CheckSequence(averages);
    //}

    //static double CalculateAverageWithoutMinMax(int[,] matrix)
    //{
    //    int min = matrix[0, 0];
    //    int max = matrix[0, 0];
    //    double sum = 0;
    //    int count = 0;

    //    foreach (int element in matrix)
    //    {
    //        if (element < min)
    //            min = element;

    //        if (element > max)
    //            max = element;

    //        sum += element;
    //        count++;
    //    }

    //    sum = sum - min - max;
    //    count = count - 2;

    //    double average = count > 0 ? sum / count : 0; // Заменяем NaN на 0
    //    return average;
    //}

    //static void CheckSequence(double[] array)
    //{
    //    bool increasing = true;
    //    bool decreasing = true;

    //    for (int i = 1; i < array.Length; i++)
    //    {
    //        if (array[i] > array[i - 1])
    //            decreasing = false;

    //        if (array[i] < array[i - 1])
    //            increasing = false;
    //    }

    //    if (increasing)
    //        Console.WriteLine("Последовательность возрастающая.");
    //    else if (decreasing)
    //        Console.WriteLine("Последовательность убывающая.");
    //    else
    //        Console.WriteLine("Последовательность не является ни возрастающей, ни убывающей.");
    //}

    //static void PrintArray(double[] array)
    //{
    //    foreach (double element in array)
    //    {
    //        Console.Write(element + " ");
    //    }
    //    Console.WriteLine();
    //}

    //22
    //static void Main()
    //{
    //    int[,] matrix = {
    //        {5, -2, 8},
    //        {-1, 7, -4},
    //        {3, -6, 9}
    //    };

    //    int[] negativesInRows = CountNegativesInRows(matrix);
    //    int[] maxNegativesInColumns = FindMaxNegativesInColumns(matrix);

    //    Console.WriteLine("Количество отрицательных элементов в каждой строке:");
    //    PrintArray(negativesInRows);

    //    Console.WriteLine("\nМаксимальные среди отрицательных элементов в каждом столбце:");
    //    PrintArray(maxNegativesInColumns);
    //}

    //static int[] CountNegativesInRows(int[,] matrix)
    //{
    //    int[] result = new int[matrix.GetLength(0)];

    //    for (int i = 0; i < matrix.GetLength(0); i++)
    //    {
    //        int count = 0;
    //        for (int j = 0; j < matrix.GetLength(1); j++)
    //        {
    //            if (matrix[i, j] < 0)
    //            {
    //                count++;
    //            }
    //        }
    //        result[i] = count;
    //    }

    //    return result;
    //}

    //static int[] FindMaxNegativesInColumns(int[,] matrix)
    //{
    //    int[] result = new int[matrix.GetLength(1)];

    //    for (int j = 0; j < matrix.GetLength(1); j++)
    //    {
    //        int maxNegative = int.MinValue;
    //        for (int i = 0; i < matrix.GetLength(0); i++)
    //        {
    //            if (matrix[i, j] < 0 && matrix[i, j] > maxNegative)
    //            {
    //                maxNegative = matrix[i, j];
    //            }
    //        }
    //        result[j] = maxNegative;
    //    }

    //    return result;
    //}

    //static void PrintArray(int[] array)
    //{
    //    foreach (int element in array)
    //    {
    //        Console.Write(element + " ");
    //    }
    //    Console.WriteLine();
    //}
}