using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int ints = int.Parse(Console.ReadLine());


            char[,] matrix = new char[ints, ints];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = input[col];
                }

            }

            char chartofind = char.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == chartofind)
                    {
                        Console.WriteLine("({0}, {1})", i, j);
                        return;
                    }
                }
            }

            Console.WriteLine($"{chartofind} does not occur in the matrix");
        }
    }
}