using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {1, 2, 3, 4};
            int[] b = new int[] {1, 2, 3};
            List<int> list = new List<int>();
            
            for (int i = 0; i < a.Length; i++)
            {
                list.Add(a[i]);                
            }
            
            for (int i = 0; i < b.Length; i++)
            {
                list.RemoveAll(b[i]);
                
                
            }

            Console.WriteLine(0);
            Console.ReadLine();
        }
    }
}
