    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace more2dArr
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int[,] matrix = new int[sizes[0], sizes[1]];
                int sum = 0;

                int x = 0;
                int y = 0;
            

                for (int i = 0; i < sizes[0]; i++)
                {
                    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int j = 0; j < sizes[1]; j++)
                    {
                        matrix[i, j] = input[j];
                    }
                }   

                for (int i = 1; i < sizes[0]-2; i++)
                {
                    for (int j = 0; j < sizes[1]-2; j++)
                    {
                        if((matrix[i,j] + matrix[i,j+1] + matrix[i, j + 2]) + (matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]) + (matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2]) > sum)
                        {
                            sum = (matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]) + (matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]) + (matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2]);

                            x = i;
                            y = j;                        
                        }                  
                    }
                
                }

                Console.WriteLine("Sum = " + sum);

                for (int i = x; i <= x+2; i++)
                {
                    for (int j = y; j <= y+2; j++)
                    {
                        if (j == y + 2)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        else
                        {
                            Console.Write(matrix[i,j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            
            }
        }
    }
