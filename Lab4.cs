using System;
using System.Linq;

class Program
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintMa(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void TransformMatrix(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);
        for (int j = 0; j < numCols; j++)
        {
            int maxElement = matrix[0, j];
            int maxIndex = 0;
            for (int i = 1; i < numRows; i++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    maxIndex = i;
                }
            }
            if (maxIndex < numRows / 2)
            {
                int sumAfterMax = 0;
                for (int i = maxIndex + 1; i < numRows; i++)
                {
                    sumAfterMax += matrix[i, j];
                }

                matrix[0, j] = sumAfterMax;
            }
        }
    }

    static int FindMaxDiagonalElement(int[,] matrix)
    {
        int maxElement = matrix[0, 0];
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, i] > maxElement)
            {
                maxElement = matrix[i, i];
            }
        }
        return maxElement;
    }

    static void ReplaceElementsWithZeros(int[,] matrix, int maxValue)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);
        int maxRowIndex = -1;
        for (int i = 0; i < numRows; i++)
        {
            if (matrix[i, i] == maxValue)
            {
                maxRowIndex = i;
                break;
            }
        }
        if (maxRowIndex == -1)
        {
            Console.WriteLine("Максимальный элемент не найден.");
            return;
        }
        for (int i = 0; i < numRows; i++)
        {
            for (int j = maxRowIndex + 1; j < numCols; j++)
            {
                matrix[i, j] = 0;
            }
        }
    }

    static void Main()
    {
        //#1.3
        //int[,] matrix = new int[,]
        //{
        //    {1, 2, 3, 4},
        //    {5, 6, 7, 8},
        //    {9, 10, 11, 12},
        //    {13, 14, 15, 16}
        //};
        //int diagonalSum = 0;
        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    diagonalSum += matrix[i, i];
        //}
        //Console.WriteLine("Сумма диагональных элементов: " + diagonalSum);

        //#1.7
        //int[,] matrix = new int[,]
        //{
        //    {1, 12, 3, 14, 5},
        //    {6, 7, 8, 9, 10},
        //    {11, 2, 13, 4, 15}
        //};
        //int[] maxValues = new int[matrix.GetLength(1)];
        //for (int j = 0; j < matrix.GetLength(1); j++)
        //{
        //    int max = matrix[0, j];
        //    for (int i = 1; i < matrix.GetLength(0); i++)
        //    {
        //        if (matrix[i, j] > max)
        //        {
        //            max = matrix[i, j];
        //        }
        //    }
        //    maxValues[j] = max;
        //}
        //Console.WriteLine("Максимальные значения столбцов:");
        //foreach (var value in maxValues)
        //{
        //    Console.Write(value + " ");
        //}

        //#1.11
        //int[,] matrix = new int[,]
        //{
        //    {3, 8, 4, 2, 9, 5, 1},
        //    {6, 7, 1, 5, 3, 2, 8},
        //    {9, 4, 6, 7, 8, 1, 3},
        //    {2, 5, 9, 4, 7, 3, 6},
        //    {1, 3, 8, 6, 2, 9, 4}
        //};
        //int minInFirstColumn = matrix[0, 0];
        //int minRow = 0;
        //for (int i = 1; i < matrix.Length / 7; i++)
        //{
        //    if (matrix[i, 0] < minInFirstColumn)
        //    {
        //        minInFirstColumn = matrix[i, 0];
        //        minRow = i;
        //    }
        //}
        //int[,] newMatrix = new int[(matrix.Length - 7) / 7, 7];
        //for (int i = 0, newRow = 0; i < matrix.Length / 7; i++)
        //{
        //    if (i != minRow)
        //    {
        //        for (int j = 0; j < 7; j++)
        //        {
        //            newMatrix[newRow, j] = matrix[i, j];
        //        }
        //        newRow++;
        //    }
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < matrix.Length / 7; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.Write(matrix[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("\nМатрица после удаления строки с минимальным элементом в 1-м столбце:");
        //for (int i = 0; i < newMatrix.Length / 7; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.Write(newMatrix[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        //#1.15
        //int[,] matrix = new int[,]
        //{
        //    {3, 8, 4, 2, 9, 5, 1},
        //    {6, 7, 1, 5, 3, 2, 8},
        //    {9, 4, 6, 7, 8, 1, 3},
        //    {2, 5, 9, 4, 7, 3, 6},
        //    {1, 3, 8, 6, 2, 9, 4}
        //};
        //int rows = 5; // количество строк
        //int cols = 7; // количество столбцов
        //for (int i = 0; i < rows; i++)
        //{
        //    int maxInRow = matrix[i, 0];
        //    int maxColumn = 0;
        //    for (int j = 1; j < cols; j++)
        //    {
        //        if (matrix[i, j] > maxInRow)
        //        {
        //            maxInRow = matrix[i, j];
        //            maxColumn = j;
        //        }
        //    }
        //    matrix[i, maxColumn] *= i + 1;
        //}
        //Console.WriteLine("Матрица после преобразования:");
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write(matrix[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        //#1.19
        //int n = 5; // количество строк
        //int m = 7; // количество столбцов
        //int[,] matrix = new int[,]
        //{
        //    {3, -8, 4, 2, 9, -5, 1},
        //    {-6, -7, 1, -5, 3, 2, 8},
        //    {-9, -4, 6, -7, -8, 1, 3},
        //    {2, -5, 9, 4, 7, 3, -6},
        //    {-1, -3, 8, -6, 2, -9, 4}
        //};
        //for (int i = 0; i < n; i++)
        //{
        //    int maxIndex = 0;
        //    for (int j = 1; j < m; j++)
        //    {
        //        if (matrix[i, j] > matrix[i, maxIndex])
        //        {
        //            maxIndex = j;
        //        }
        //    }
        //    for (int j = 0; j < maxIndex; j++)
        //    {
        //        if (matrix[i, j] < 0)
        //        {
        //            matrix[i, j] /= matrix[i, maxIndex];
        //        }
        //    }
        //}
        //Console.WriteLine("Матрица после преобразования:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(matrix[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        //#1.23
        //int[,] matrixG = new int[5, 7]
        //{
        //    {1, 5, 3, 7, 2, 6, 0},
        //    {8, 2, 4, 1, 9, 3, 0},
        //    {6, 7, 2, 4, 8, 1, 0},
        //    {9, 4, 7, 2, 5, 8, 0},
        //    {3, 6, 1, 5, 4, 7, 0}
        //};
        //Console.WriteLine("Исходная матрица:");
        //PrintMatrix(matrixG);
        //for (int i = 0; i < 5; i++)
        //{
        //    int maxElement = int.MinValue;
        //    int minElement = int.MaxValue;
        //    int maxElementIndex = -1;
        //    int minElementIndex = -1;
        //    for (int j = 0; j < 6; j++)
        //    {
        //        if (matrixG[i, j] > maxElement)
        //        {
        //            maxElement = matrixG[i, j];
        //            maxElementIndex = j;
        //        }

        //        if (matrixG[i, j] < minElement)
        //        {
        //            minElement = matrixG[i, j];
        //            minElementIndex = j;
        //        }
        //    }
        //    for (int j = 6; j > minElementIndex; j--)
        //    {
        //        matrixG[i, j] = matrixG[i, j - 1];
        //    }

        //    matrixG[i, minElementIndex + 1] = maxElement;
        //}
        //Console.WriteLine("\nМатрица после обработки:");
        //PrintMatrix(matrixG);

        //#1.27
        //int[,] matrixB = new int[5, 7]
        //{
        //    {1, 5, 3, 7, 2, 6, 4},
        //    {8, 2, 4, 1, 9, 3, 5},
        //    {6, 7, 2, 4, 8, 1, 3},
        //    {9, 4, 7, 2, 5, 8, 1},
        //    {3, 6, 1, 5, 4, 7, 2}
        //};
        //Console.WriteLine("Исходная матрица:");
        //PrintMatrix(matrixB);
        //for (int i = 0; i < 5; i++)
        //{
        //    int maxElement = int.MinValue;
        //    for (int j = 0; j < 7; j++)
        //    {
        //        if (matrixB[i, j] > maxElement)
        //        {
        //            maxElement = matrixB[i, j];
        //        }
        //    }
        //    matrixB[i, 3] = maxElement;
        //}
        //Console.WriteLine("\nМатрица после обработки:");
        //PrintMatrix(matrixB);

        //#1.31
        //int[,] A = new int[5, 7]
        //{
        //    {1, 3, 4, 2, 5, 8, 9},
        //    {6, 2, 5, 7, 8, 0, 3},
        //    {9, 4, 8, 2, 1, 3, 5},
        //    {4, 6, 2, 9, 3, 1, 7},
        //    {7, 5, 3, 8, 6, 4, 9}
        //};
        //int imin = 0;
        //int minel = A[4, 0];
        //for (int i = 1; i < 7; i++)
        //{
        //    if (A[4, i] < minel)
        //    {
        //        minel = A[4, i];
        //        imin = i;
        //    }
        //}
        //int[] B = new int[] { 1, 2, 3, 4, 5 };
        //int[,] result = new int[5, 8];
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j <= imin; j++)
        //    {
        //        result[i, j] = A[i, j];
        //    }
        //    result[i, imin + 1] = B[i];
        //    for (int j = imin + 2; j < 8; j++)
        //    {
        //        result[i, j] = A[i, j - 1];
        //    }
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 8; j++)
        //    {
        //        Console.Write(result[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        //#2.3
        //int[,] matrixA = new int[10, 5];
        //Random random = new Random();

        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        matrixA[i, j] = random.Next(1, 100);
        //    }
        //}

        //Console.WriteLine("Исходная матрица A:");
        //PrintMa(matrixA);

        //TransformMatrix(matrixA);

        //Console.WriteLine("\nМатрица A после преобразования:");
        //PrintMa(matrixA);

        //2.7
        //int[,] matrixA = new int[6, 6];
        //Random random = new Random();

        //for (int i = 0; i < 6; i++)
        //{
        //    for (int j = 0; j < 6; j++)
        //    {
        //        matrixA[i, j] = random.Next(1, 100);
        //    }
        //}

        //Console.WriteLine("Исходная матрица A:");
        //PrintMa(matrixA);

        //int maxDiagonalElement = FindMaxDiagonalElement(matrixA);
        //ReplaceElementsWithZeros(matrixA, maxDiagonalElement);

        //Console.WriteLine("\nМатрица A после замены:");
        //PrintMa(matrixA);

        //3.3
        //int n = Int32.Parse(Console.ReadLine());
        //if (n > 0)
        //{
        //    double[,] a = new double[n, n];
        //    double[] b = new double[2 * n - 1];
        //    double sum = 0;
        //    Console.WriteLine();
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            Console.WriteLine("[" + i + "," + j + "]");
        //            a[i, j] = Double.Parse(Console.ReadLine());
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //    int index = 0;
        //    for (int i = n - 1; i > -1; i--)
        //    {
        //        for (int j = 0; j < n - i; j++)
        //        {
        //            sum += a[i + j, j];
        //        }
        //        b[index] = sum;
        //        index++;
        //        sum = 0;
        //    }
        //    for (int j = 1; j < n; j++)
        //    {
        //        for (int i = 0; i < n - j; i++)
        //        {
        //            sum += a[i, j + i];
        //        }
        //        b[index] = sum;
        //        index++;
        //        sum = 0;
        //    }
        //    for (int i = 0; i < 2 * n - 1; i++)
        //    {
        //        Console.Write(b[i] + " ");
        //    }
        //}

        //3.4
        //int n = Convert.ToInt32(Console.ReadLine());
        //int[,] a = new int[n, n];
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        a[i, j] = Convert.ToInt32(Console.ReadLine());
        //        if ((i >= (n / 2)) && (i >= j))
        //        {
        //            a[i, j] = 1;
        //        }
        //    }
        //}
        //for (int i = 0; i < n; ++i)
        //{
        //    for (int j = 0; j < n; ++j)
        //    {
        //        Console.Write(a[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}  
