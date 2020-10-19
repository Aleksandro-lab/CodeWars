using System;
using System.Collections.Generic;
using System.Windows;


namespace CodeWarsKata3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> josefus = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 };
            int turn = 6;
            List<object> fin = JosephusPermutation(josefus, turn);
            foreach(var element in fin)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }

        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            List<object> count = new List<object>();
            int cnt = 0;

            while (count.Count < items.Count)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i] != null)
                    {
                        cnt++;
                        if (cnt % k == 0)
                        {
                            count.Add(items[i]);
                            items[i] = null;
                        }
                    }
                }
            }
          
            return count;
        }
    }
}
