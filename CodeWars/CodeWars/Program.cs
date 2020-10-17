using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 5, 3, 2, 8, 1, 4 };
            int[] arraySec = new int[array.Length];
            
            int max = 0;
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    break;
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
            

        }
    }
}
