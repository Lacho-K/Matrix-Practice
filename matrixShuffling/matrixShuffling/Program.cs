﻿using System;
using System.Linq;

namespace matrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] arr2d = new string[sizes[0],sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < sizes[1]; j++)
                {
                    arr2d[i,j] = input[j];                    
                }                
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                if(command[0] == "END")
                {
                    break;
                }
                else if(command[0] == "swap" && command.Length == 5)
                {
                    if(Valid(int.Parse(command[1]), int.Parse(command[2]), int.Parse(command[3]), int.Parse(command[4]), sizes[0], sizes[1]))
                    {
                        string temp = arr2d[int.Parse(command[1]), int.Parse(command[2])];
                        arr2d[int.Parse(command[1]), int.Parse(command[2])] = arr2d[int.Parse(command[3]), int.Parse(command[4])];
                        arr2d[int.Parse(command[3]), int.Parse(command[4])] = temp;
                        for (int i = 0; i < sizes[0]; i++)
                        {
                            for (int j = 0; j < sizes[1]; j++)
                            {
                                Console.Write(arr2d[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }                
            }            

        }

        static bool Valid(int row1, int col1, int row2, int col2, int size1, int size2)
        {
            if(row1>=0 && row1 < size1 && row2 >= 0 && row2 < size1 && col1 >= 0 && col1 < size2 && col2 >= 0 && col2 < size2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
