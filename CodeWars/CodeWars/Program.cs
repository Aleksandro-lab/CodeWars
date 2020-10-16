using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = 10;
            int cnt = 0;
            for (int i = 3; i < maxNum; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    cnt = cnt + i;
                }
            }
            Console.WriteLine(cnt);
            Console.ReadLine();
        }
    }
}
