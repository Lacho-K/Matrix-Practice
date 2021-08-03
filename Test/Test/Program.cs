using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jag = new int[rows][];

            for (int i = 0; i < jag.Length; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jag[i] = new int[nums.Length];
                for (int j = 0; j < jag[i].Length; j++)
                {
                    jag[i][j] = nums[j];
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                
                if(input[0] == "END")
                {
                    break;
                }
                else
                {
                    if (input[0] == "Add")
                    {
                        if (int.Parse(input[1]) >= 0 && int.Parse(input[1]) < rows && int.Parse(input[2]) >= 0 && int.Parse(input[2]) < jag[int.Parse(input[1])].Length)
                        {                                                      
                            jag[int.Parse(input[1])][int.Parse(input[2])] += int.Parse(input[3]);                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                    }
                    else if (input[0] == "Subtract")
                    {
                        if (int.Parse(input[1]) >= 0 && int.Parse(input[1]) < rows && int.Parse(input[2]) >= 0 && int.Parse(input[2]) < jag[int.Parse(input[1])].Length)
                        {                            
                            jag[int.Parse(input[1])][int.Parse(input[2])] -= int.Parse(input[3]);                       
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                    }
                }
            }

            foreach (var item in jag)
            {
                Console.WriteLine(String.Join(' ', item));
            }
           
        }
    }
}
