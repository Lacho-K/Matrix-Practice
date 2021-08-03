using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(10);
                }
            }

            Console.WriteLine("Normal:" + "\n");

            PrintMatrix(matrix);

            Console.WriteLine();

            int[,] matrix2 = Transponate(matrix);
           
            Console.WriteLine("Transposed:" + "\n");

            PrintMatrix(matrix2);

            Console.WriteLine();

            Console.WriteLine("Multiplied:" + "\n");

            MatrixMultiplication(matrix, matrix2);

            Console.WriteLine();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] Transponate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int colls = matrix.GetLength(1);
            int[,] matrix2 = new int[colls, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    matrix2[j, i] = matrix[i, j];
                }
            }
            return matrix2;
        }

        static void MatrixMultiplication(int[,] m1, int[,] m2)
        {
            int m1R = m1.GetLength(0);
            int m1C = m1.GetLength(1);
            int m2R = m2.GetLength(0);
            int m2C = m2.GetLength(1);
            if(m1C == m2R)
            {
                int[,] m3 = new int[m1R, m2C];

                for (int i = 0; i < m1R; i++)
                {
                    for (int j = 0; j < m2C; j++)
                    {
                        for (int k = 0; k < m1C; k++)
                        {
                            m3[i, j] += m1[i, k] * m2[k, j];
                        }
                    }
                }                    
                  
                PrintMatrix(m3);
            }
            else throw new Exception("Not valid sizes");
        }
    }
}