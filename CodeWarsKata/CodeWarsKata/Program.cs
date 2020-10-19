using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CodeWarsKata
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            string word = "abba";
            
            
            

            
            //Console.WriteLine(String.Compare(word3, word4));
            
            
            
            var words = new List<string> { "abab", "bbaa", "bbbaa" };
            var fin = new List<string>(Anagrams(word, words));
            foreach(var element in fin)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
        static string SortString(string word)
        {
            char[] sorted = word.ToArray();
            Array.Sort(sorted);

            return new string (sorted);
        }
        public static List<string> Anagrams(string word, List<string> words)
        {
            var wordList = new List<string>();
            var finList = new List<string>();
            foreach (var elements in words)
            {
                if (SortString(elements) == SortString(word))
                {
                    finList.Add(elements);
                }
            }
            return finList;
        }
    }
}
