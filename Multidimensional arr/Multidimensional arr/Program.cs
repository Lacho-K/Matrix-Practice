using System;
using System.Linq;

namespace Multidimensional_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] arr2d = new int[size, size];
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < size; i++)
            {
                int[] current = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {                                      
                    arr2d[i, j] = current[j];                                   
                }
            }
            for (int i = 0; i < size; i++)
            {
                sum1 += arr2d[i, i];                
            }
            int exIndex = 0;
            for (int i = size - 1; i >= 0; i--)
            {                
                sum2 += arr2d[i, exIndex];
                exIndex++;
            }
            Console.WriteLine(Math.Abs(sum2-sum1));
        }
    }
}
