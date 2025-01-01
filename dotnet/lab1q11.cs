using System;

class Program
{
    static void Main(string[] args)
    {
        // Input dimensions of the first matrix
        Console.Write("Enter the number of rows for the first matrix: ");
        int rows1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of columns for the first matrix: ");
        int cols1 = Convert.ToInt32(Console.ReadLine());

        // Input dimensions of the second matrix
        Console.Write("Enter the number of rows for the second matrix: ");
        int rows2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of columns for the second matrix: ");
        int cols2 = Convert.ToInt32(Console.ReadLine());

        // Ensure matrices can be multiplied
        if (cols1 != rows2)
        {
            Console.WriteLine("Matrix multiplication is not possible with these dimensions.");
            return;
        }

        // Input the first matrix
        int[,] matrix1 = new int[rows1, cols1];
        Console.WriteLine("Enter elements of the first matrix:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Input the second matrix
        int[,] matrix2 = new int[rows2, cols2];
        Console.WriteLine("Enter elements of the second matrix:");
        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Initialize the result matrix
        int[,] result = new int[rows1, cols2];

        // Perform matrix multiplication
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        // Print the result matrix
        Console.WriteLine("Resultant Matrix after Multiplication:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
