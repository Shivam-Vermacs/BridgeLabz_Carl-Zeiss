using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class _2dArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the columns");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            int[,]matrix2 = new int[rows, cols];
            int[,] result = new int[cols, rows];
            Console.WriteLine("Enter the elements of the matrix");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0;j<cols;j++)
                {
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("Enter the elements of the matrix2");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] + matrix2[i, j];

                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(result[i, j] + " ");

                }
            }

        }
    }
}
