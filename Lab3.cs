using System;
using System.Linq;

class Program
{
    static void printArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        //Console.WriteLine("1.1: ");
        //int[] myArray = { 10, 20, 30, 40, 50, 60 };
        //double sum = 0;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    sum += myArray[i];
        //}
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    myArray[i] = (int)(myArray[i] / sum * 100);
        //}
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    Console.Write(myArray[i] + " ");
        //}

        //Console.WriteLine("1.2: ");
        //int[] myArray = { -2, 3, 5, -8, 10, -4, 6, 12 };
        //int sum = 0;
        //int count = 0;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    if (myArray[i] > 0)
        //    {
        //        sum += myArray[i];
        //        count++;
        //    }
        //}
        //if (count > 0)
        //{
        //    int average = sum / count;
        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        if (myArray[i] > 0)
        //        {
        //            myArray[i] = average;
        //        }
        //    }
        //}
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    Console.Write(myArray[i] + " ");
        //}

        //Console.WriteLine("1.3: ");
        //int[] array1 = { 10, 20, 30, 40 };
        //int[] array2 = { 5, 15, 25, 35 };
        //int[] sumArray = new int[4];
        //int[] differenceArray = new int[4];
        //for (int i = 0; i < 4; i++)
        //{
        //    sumArray[i] = array1[i] + array2[i];
        //    differenceArray[i] = array1[i] - array2[i];
        //}
        //Console.WriteLine("Сумма массивов:");
        //for (int i = 0; i < 4; i++)
        //{
        //    Console.Write(sumArray[i] + " ");
        //}
        //Console.WriteLine("\n");
        //Console.WriteLine("Разность массивов:");
        //for (int i = 0; i < 4; i++)
        //{
        //    Console.Write(differenceArray[i] + " ");
        //}

        //Console.WriteLine("1.4: ");
        //int[] myArray = { 10, 20, 30, 40, 50 };
        //int sum = 0;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    sum += myArray[i];
        //}
        //int average = sum / myArray.Length;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    myArray[i] -= average;
        //}
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    Console.Write(myArray[i] + " ");
        //}

        //Console.WriteLine("1.5: ");
        //int[] vector1 = { 1, 2, 3, 4 };
        //int[] vector2 = { 5, 6, 7, 8 };
        //int scalarProduct = 0;
        //for (int i = 0; i < vector1.Length; i++)
        //{
        //    scalarProduct += vector1[i] * vector2[i];
        //}
        //Console.WriteLine(scalarProduct);

        //Console.WriteLine("1.6: ");
        //int[] vector = { 1, 2, 3, 4, 5 };
        //int sumOfSquares = 0;
        //for (int i = 0; i < vector.Length; i++)
        //{
        //    sumOfSquares += vector[i] * vector[i];
        //}
        //double length = Math.Sqrt(sumOfSquares);
        //Console.WriteLine("Длина вектора: " + length);

        //Console.WriteLine("1.7: ");
        //double[] myArray = { 10, 20, 30, 40, 50, 60, 70 };
        //double sum = 0;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    sum += myArray[i];
        //}
        //double average = sum / myArray.Length;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    if (myArray[i] > average)
        //    {
        //        myArray[i] = 0;
        //    }
        //}
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    Console.Write(myArray[i] + " ");
        //}

        //Console.WriteLine("1.8: ");
        //int[] myArray = { -7, 8, -1, 5, 4, -5 };
        //int kolichestvo = 0;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    if (myArray[i] < 0)
        //    {
        //        kolichestvo += 1;
        //    }
        //}
        //Console.WriteLine(kolichestvo);

        //Console.WriteLine("1.9: ");
        //int[] myArray = { 10, 20, 30, 40, 50, 60, 70, 80 };
        //double sum = 0.0;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    sum += myArray[i];
        //}
        //double average = sum / myArray.Length;
        //int count = 0;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    if (myArray[i] > average)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);

        //Console.WriteLine("1.10: ");
        //int[] myArray = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 33 };
        //int P = 15;
        //int Q = 40;
        //int count = 0;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    if (myArray[i] > P & myArray[i] < Q)
        //    {
        //        count += 1;
        //    }
        //}
        //Console.WriteLine(count);

        //Console.WriteLine("1.11: ");
        //int[] myArray = { -2, 5, -7, 10, 8, -3, 15, 0, 20, -1 };
        //int[] positiveArray = new int[myArray.Length];
        //int positiveCount = 0;
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    if (myArray[i] > 0)
        //    {
        //        positiveArray[positiveCount] = myArray[i];
        //        positiveCount++;
        //    }
        //}
        //int[] resultArray = new int[positiveCount];
        //for (int i = 0; i < resultArray.Length; i++)
        //{
        //    resultArray[i] = positiveArray[i];
        //}
        //for (int i = 0; i < resultArray.Length; i++)
        //{
        //    Console.Write(resultArray[i] + " ");
        //}

        //Console.WriteLine("1.12: ");
        //int[] array = { 1, 2, -3, 4, -5, 6, 7, -8 };
        //int lastIndex = -1;
        //int lastNegativeValue = 0;

        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        lastIndex = i;
        //        lastNegativeValue = array[i];
        //    }
        //}
        //Console.WriteLine($"Последний отрицательный элемент: {lastNegativeValue}");
        //Console.WriteLine($"Номер последнего отрицательного элемента: {lastIndex + 1}");

        //Console.WriteLine("1.13: ");
        //int[] sourceArray = new int[10];
        //Random random = new Random();
        //for (int i = 0; i < sourceArray.Length; i++)
        //{
        //    sourceArray[i] = random.Next(1, 100);
        //}
        //int[] evenArray = new int[5];
        //int[] oddArray = new int[5];
        //int evenIndex = 0;
        //int oddIndex = 0;
        //for (int i = 0; i < sourceArray.Length; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        evenArray[evenIndex] = sourceArray[i];
        //        evenIndex++;
        //    }
        //    else
        //    {
        //        oddArray[oddIndex] = sourceArray[i];
        //        oddIndex++;
        //    }
        //}
        //Console.WriteLine("Исходный массив:");
        //for (int i = 0; i < sourceArray.Length; i++)
        //{
        //    Console.Write(sourceArray[i] + " ");
        //}
        //Console.WriteLine("\n");
        //Console.WriteLine("Массив с четными индексами:");
        //for (int i = 0; i < evenArray.Length; i++)
        //{
        //    Console.Write(evenArray[i] + " ");
        //}
        //Console.WriteLine("\n");
        //Console.WriteLine("Массив с нечетными индексами:");
        //for (int i = 0; i < oddArray.Length; i++)
        //{
        //    Console.Write(oddArray[i] + " ");
        //}

        //Console.WriteLine("1.14: ");
        //int[] array = new int[11];
        //Random random = new Random();
        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = random.Next(-10, 10);
        //}
        //int sumOfSquares = 0;
        //bool foundNegative = false;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        foundNegative = true;
        //        break;
        //    }
        //    sumOfSquares += array[i] * array[i];
        //}
        //Console.WriteLine("Исходный массив:");
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write(array[i] + " ");
        //}
        //Console.WriteLine("\n");
        //if (foundNegative)
        //{
        //    Console.WriteLine("Сумма квадратов элементов до первого отрицательного элемента: " + sumOfSquares);
        //}
        //else
        //{
        //    Console.WriteLine("В массиве нет отрицательных элементов.");
        //}

        //Console.WriteLine("1.15: ");
        //double[] x = new double[10];
        //double[] y = new double[10];
        //Random random = new Random();
        //for (int i = 0; i < x.Length; i++)
        //{
        //    x[i] = random.Next(1, 100);
        //}
        //for (int i = 0; i < x.Length; i++)
        //{
        //    y[i] = 0.5 * Math.Log(x[i]);
        //}
        //Console.WriteLine("x\ty");
        //for (int i = 0; i < x.Length; i++)
        //{
        //    Console.WriteLine($"{x[i]}\t{y[i]}");
        //}

        int[] array = { 3, 6, -2, 9, 4, -5, 1, 8, -7, 0 };

        //Console.WriteLine("2.1: ");
        //int minIndex = 0;
        //int min = array[0];
        //for (int i = 1; i < array.Length; i++)
        //{
        //    if (array[i] < min)
        //    {
        //        min = array[i];
        //        minIndex = i;
        //    }
        //}
        //array[minIndex] *= 2;
        //printArray(array);

        //Console.WriteLine("2.2: ");
        //int max = int.MinValue;
        //int sumBeforeMax = 0;

        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > max)
        //    {
        //        max = array[i];
        //    }
        //}
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] != max)
        //    {
        //        sumBeforeMax += array[i];
        //    }
        //    else
        //    {
        //        break;
        //    }
        //}
        //Console.WriteLine(sumBeforeMax);

        //Console.WriteLine("2.3: ");
        //int min = int.MaxValue;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < min)
        //    {
        //        min = array[i];
        //    }
        //}
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] != min)
        //    {
        //        array[i] *= 2;
        //    }
        //    else
        //    {
        //        break;
        //    }
        //}
        //printArray(array);

        //Console.WriteLine("2.4: ");
        //double average = 0;
        //int max = int.MinValue;
        //int maxIndex = -10;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > max)
        //    {
        //        max = array[i];
        //        maxIndex = i;
        //    }
        //}
        //for (int i = 0; i < array.Length; i++)
        //{
        //    average += array[i];
        //}
        //average /= array.Length;
        //for (int i = maxIndex + 1; i < array.Length; i++)
        //{
        //    array[i] = (int)average;
        //}
        //printArray(array);

        //Console.WriteLine("2.5: ");
        //int max = int.MinValue;
        //int min = int.MaxValue;
        //int maxIndex = 1000;
        //int minIndex = -1000;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > max)
        //    {
        //        max = array[i];
        //        maxIndex = i;
        //    }
        //}
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < min)
        //    {
        //        min = array[i];
        //        minIndex = i;
        //    }
        //}
        //int minBetweenMaxMin = Math.Min(maxIndex, minIndex);
        //int maxBetweenMaxMin = Math.Max(maxIndex, minIndex);
        //int[] negativeElements = new int[maxBetweenMaxMin - minBetweenMaxMin - 1];
        //int negativeCount = 0;
        //for (int i = minBetweenMaxMin + 1; i < maxBetweenMaxMin; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        negativeElements[negativeCount] = array[i];
        //        negativeCount++;
        //    }
        //}
        //printArray(negativeElements);

        //Console.WriteLine("2.6: ");
        //double average = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    average += array[i];
        //}
        //average /= array.Length;
        //double closestToAverage = Math.Abs(array[0] - average);
        //int closestToAverageIndex = 0;
        //int p = 42;
        //for (int i = 1; i < array.Length; i++)
        //{
        //    double diff = Math.Abs(array[i] - average);
        //    if (diff < closestToAverage)
        //    {
        //        closestToAverage = diff;
        //        closestToAverageIndex = i;
        //    }
        //}
        //double[] newArray = new double[array.Length + 1];
        //for (int i = 0; i <= closestToAverageIndex; i++)
        //{
        //    newArray[i] = array[i];
        //}
        //newArray[closestToAverageIndex + 1] = p;
        //for (int i = closestToAverageIndex + 2; i < newArray.Length; i++)
        //{
        //    newArray[i] = array[i - 1];
        //}
        //array = newArray;
        //foreach (var element in array)
        //{
        //    Console.Write(element + " ");
        //}

        //Console.WriteLine("2.7: ");
        //int max = int.MinValue;
        //int maxIndex = -1;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > max)
        //    {
        //        max = array[i];
        //        maxIndex = i;
        //    }
        //}
        //if (maxIndex < array.Length - 1)
        //{
        //    array[maxIndex + 1] *= 2;
        //}
        //printArray(array);

        //Console.WriteLine("2.8: ");
        //int max = int.MinValue;
        //int maxIndex = 1000;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > max)
        //    {
        //        max = array[i];
        //        maxIndex = i;
        //    }
        //}
        //int minAfterMax = int.MaxValue;
        //int minAfterMaxIndex = -1;
        //for (int i = maxIndex + 1; i < array.Length; i++)
        //{
        //    if (array[i] < minAfterMax)
        //    {
        //        minAfterMax = array[i];
        //        minAfterMaxIndex = i;
        //    }
        //}
        //array[maxIndex] = minAfterMax;
        //array[minAfterMaxIndex] = max;
        //printArray(array);

        //Console.WriteLine("2.9: ");
        //int max = int.MinValue;
        //int min = int.MaxValue;
        //int maxIndex = 1000;
        //int minIndex = -1000;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > max)
        //    {
        //        max = array[i];
        //        maxIndex = i;
        //    }
        //}
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < min)
        //    {
        //        min = array[i];
        //        minIndex = i;
        //    }
        //}
        //int mini= Math.Min(maxIndex, minIndex);
        //int maxi = Math.Max(maxIndex, minIndex);
        //int sumBetweenMinMax = 0;
        //for (int i = mini + 1; i < maxi; i++)
        //{
        //    sumBetweenMinMax += array[i];
        //}
        //double averageBetweenMinMax = (double)sumBetweenMinMax / (maxi - mini - 1);
        //Console.WriteLine(averageBetweenMinMax);

        //Console.WriteLine("2.10: ");
        //int minPositive = int.MaxValue;
        //int minPositiveIndex = -1;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > 0 && array[i] < minPositive)
        //    {
        //        minPositive = array[i];
        //        minPositiveIndex = i;
        //    }
        //}
        //if (minPositiveIndex != -1)
        //{
        //    int[] newArray = new int[array.Length - 1];
        //    for (int i = 0; i < minPositiveIndex; i++)
        //    {
        //        newArray[i] = array[i];
        //    }
        //    for (int i = minPositiveIndex + 1; i < array.Length; i++)
        //    {
        //        newArray[i - 1] = array[i];
        //    }
        //    array = newArray;
        //}
        //printArray(array);

        //Console.WriteLine("2.11: ");
        //int p = 99;
        //int lastPositiveIndex = -1;
        //for (int i = array.Length - 1; i >= 0; i--)
        //{
        //    if (array[i] > 0)
        //    {
        //        lastPositiveIndex = i;
        //        break;
        //    }
        //}
        //if (lastPositiveIndex != -1) { 
        //    for (int i = array.Length - 1; i > lastPositiveIndex; i--)
        //    {
        //        array[i] = array[i - 1];
        //    }
        //    array[lastPositiveIndex + 1] = p;
        //    foreach (int element in array)
        //    {
        //        Console.Write(element + " ");
        //    }
        //}

        //Console.WriteLine("2.12: ");
        //int otrValueIndex = -1;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        otrValueIndex = i;
        //        break;
        //    }
        //}
        //int maxValue = int.MinValue;
        //int sum = 0;
        //int maxValueIndex = -1;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > maxValue)
        //    {
        //        maxValue = array[i];
        //        maxValueIndex = i;
        //    }
        //}
        //for (int i = maxValueIndex + 1; i < array.Length; i++)
        //{
        //    sum += array[i];
        //}
        //array[otrValueIndex] = sum;
        //printArray(array);

        //Console.WriteLine("2.13: ");
        //int maxEven = int.MinValue;
        //int maxEvenIndex = -1;
        //for (int i = 0; i < array.Length; i += 2)
        //{
        //    if (array[i] > maxEven)
        //    {
        //        maxEven = array[i];
        //        maxEvenIndex = i;
        //    }
        //}
        //array[maxEvenIndex] = maxEvenIndex;
        //printArray(array);

        //Console.WriteLine("2.14: ");
        //int maxValue = int.MinValue;
        //int maxIndex = -1;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > maxValue)
        //    {
        //        maxValue = array[i];
        //        maxIndex = i;
        //    }
        //}
        //int firstNegativeIndex = -1;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        firstNegativeIndex = i;
        //        break;
        //    }
        //}
        //int temp = array[maxIndex];
        //array[maxIndex] = array[firstNegativeIndex];
        //array[firstNegativeIndex] = temp;
        //printArray(array);

        //Console.WriteLine("2.15: ");
        //int[] A = { 3, 5, -2, 8, 7 };
        //int[] B = { 1, 2, 3 };
        //int k = 2;
        //int[] result = new int[A.Length + B.Length];
        //for (int i = 0; i <= k; i++)
        //{
        //    result[i] = A[i];
        //}
        //for (int i = 0; i < B.Length; i++)
        //{
        //    result[k + i + 1] = B[i];
        //}
        //for (int i = k + 1; i < A.Length; i++)
        //{
        //    result[i + B.Length] = A[i];
        //}
        //A = result;
        //printArray(A);

        //Console.WriteLine("2.16: ");
        //double average = 0;
        //foreach (int element in array)
        //{
        //    average += element;
        //}
        //average /= array.Length;
        //int count = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < average)
        //    {
        //        count++;
        //    }
        //}
        //int[] resultArray = new int[count];
        //int index = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < average)
        //    {
        //        resultArray[index] = i;
        //        index++;
        //    }
        //}
        //foreach (int element in resultArray)
        //{
        //    Console.Write(element + " ");
        //}

        //Console.WriteLine("2.17: ");
        //int maxIndex = 0;
        //int minIndex = 0;
        //for (int i = 1; i < array.Length; i++)
        //{
        //    if (array[i] > array[maxIndex])
        //    {
        //        maxIndex = i;
        //    }
        //    if (array[i] < array[minIndex])
        //    {
        //        minIndex = i;
        //    }
        //}
        //double average;
        //if (maxIndex < minIndex)
        //{
        //    int positiveCount = 0;
        //    int positiveSum = 0;
        //    foreach (int num in array)
        //    {
        //        if (num > 0)
        //        {
        //            positiveSum += num;
        //            positiveCount++;
        //        }
        //    }
        //    average = positiveCount > 0 ? (double)positiveSum / positiveCount : 0;
        //}
        //else
        //{
        //    int negativeCount = 0;
        //    int negativeSum = 0;
        //    foreach (int num in array)
        //    {
        //        if (num < 0)
        //        {
        //            negativeSum += num;
        //            negativeCount++;
        //        }
        //    }
        //    average = negativeCount > 0 ? (double)negativeSum / negativeCount : 0;
        //}
        //Console.WriteLine(average);

        //Console.WriteLine("2.18: ");
        //int maxEven18 = array[0];
        //int maxOdd18 = array[1];
        //for (int i = 2; i < array.Length; i += 2)
        //{
        //    maxEven18 = Math.Max(maxEven18, array[i]);
        //}
        //for (int i = 3; i < array.Length; i += 2)
        //{
        //    maxOdd18 = Math.Max(maxOdd18, array[i]);
        //}
        //if (maxEven18 > maxOdd18)
        //{
        //    for (int i = 0; i < array.Length / 2; i++)
        //    {
        //        array[i] = 0;
        //    }
        //}
        //else
        //{
        //    for (int i = array.Length / 2; i < array.Length; i++)
        //    {
        //        array[i] = 0;
        //    }
        //}
        //printArray(array);

        //Console.WriteLine("2.19: ");
        //int maxElement = array[0];
        //int maxIndex = 0;
        //int sum = 0;
        //foreach (int num in array)
        //{
        //    maxElement = Math.Max(maxElement, num);
        //    sum += num;
        //}
        //if (maxElement > sum)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] == maxElement)
        //        {
        //            maxIndex = i;
        //            break;
        //        }
        //    }
        //    array[maxIndex] = 0;
        //}
        //else
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] *= 2;
        //    }
        //}
        //foreach (int element in array)
        //{
        //    Console.Write(element + " ");
        //}

        //Console.WriteLine("2.20: ");
        //int firstNegativeIndex = -1;
        //int minIndex = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        firstNegativeIndex = i;
        //        break;
        //    }
        //    if (array[i] < array[minIndex])
        //    {
        //        minIndex = i;
        //    }
        //}
        //int sum = 0;
        //if (firstNegativeIndex < minIndex)
        //{
        //    for (int i = 0; i < array.Length; i += 2)
        //    {
        //        sum += array[i];
        //    }
        //}
        //else
        //{
        //    for (int i = 1; i < array.Length; i += 2)
        //    {
        //        sum += array[i];
        //    }
        //}
        //Console.WriteLine(sum);

        //Console.WriteLine("3.1: ");
        //int max = int.MinValue;
        //foreach (int num in array)
        //{
        //    if (num > max)
        //    {
        //        max = num;
        //    }
        //}
        //int count = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] == max)
        //    {
        //        count++;
        //    }
        //}
        //int[] maxIndexes = new int[count];
        //int index = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] == max)
        //    {
        //        maxIndexes[index] = i;
        //        index++;
        //    }
        //}
        //foreach (int idx in maxIndexes)
        //{
        //    Console.Write(idx + " ");
        //}

        //Console.WriteLine("3.2: ");
        //int max = int.MinValue;
        //foreach (int num in array)
        //{
        //    if (num > max)
        //    {
        //        max = num;
        //    }
        //}
        //int count = 0;
        //foreach (int num in array)
        //{
        //    if (num == max)
        //    {
        //        count++;
        //    }
        //}
        //int order = 1;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] == max)
        //    {
        //        array[i] += order;
        //        order++;
        //    }
        //}
        //foreach (int element in array)
        //{
        //    Console.Write(element + " ");
        //}
    }
}