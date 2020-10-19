using System;

namespace CodeWarsKata2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "aabbcde";
            int cnt = DuplicateCount(word);
            Console.WriteLine(cnt);
            Console.ReadLine();
        }

        public static int DuplicateCount(string str)
        {
            str = str.ToLower();
            char[] sorted = new char[str.Length];
            sorted = str.ToCharArray();
            
            Array.Sort(sorted);
            int cnt = 0;
            int cntDouble = 0;
            char blank = sorted[0];
            
            for (int i = 1; i < sorted.Length; i++)
            {
                if (sorted[i] == blank)
                {
                    cntDouble++;
                    break;
                }
            }
            Console.WriteLine(cntDouble);
            for (int i = 1; i < sorted.Length - 1; i++)
            {
                for(int j = i+1; j < sorted.Length; j++)
                {
                    if((sorted[i] == sorted[j]) && (sorted[i] != blank))
                    {
                        
                        cnt++;
                        sorted[j] = blank;
                        
                    }
                }
                if(cnt > 0)
                {
                    cntDouble++;
                    cnt = 0;
                }
            }
            return cntDouble; 
        }
    }
}
