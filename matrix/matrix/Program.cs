using System;
using System.Linq;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = 100;
                }
            }

            while (true)
            {
                string[] coordinates = Console.ReadLine().Split(',');

                if(coordinates[0] == "GAME OVER")
                {
                    break;
                }

                int x = int.Parse(coordinates[0]);
                int y = int.Parse(coordinates[1]);
                int dmg = int.Parse(coordinates[2]);

                
                    for (int x1 = -1; x1 <= 1; x1++)
                    {
                        for (int y1 = -1; y1 <= 1; y1++)
                        {
                            if(x + x1 >= 0 && x + x1 < sizes[0] && y + y1 >= 0 && y + y1 < sizes[1])
                            {
                                if(x1 == 0 && y1 == 0)
                                {
                                    matrix[x, y] -= dmg;
                                }
                                else
                                {
                                    matrix[x + x1, y + y1] -= 10;
                                }
                            }
                        }
                    }
                
            }

            for (int i = 0; i < sizes[0]; i++)
            {
                for (int j = 0; j < sizes[1]; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
