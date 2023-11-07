using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    internal class Class2
    {
    }
}
using System;
using System.Linq;

class MathOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static int[] Add(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
            throw new ArgumentException("Arrays must be of the same length.");

        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }

        return result;
    }

    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            throw new ArgumentException("Matrices must have the same dimensions.");

        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        double[,] result = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}
