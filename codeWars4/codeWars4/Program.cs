using System;
using System.Collections.Generic;
using System.Linq;

namespace codeWars4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fin = "Pig latin is cool";
            fin = PigIt(fin);
            Console.WriteLine(fin);
            Console.ReadLine();
        }
        public static string PigIt(string str)
        {
            string pattern = " ";
            string[] elements = System.Text.RegularExpressions.Regex.Split(str, pattern);
            var listFin = new List<string>();
            foreach(var element in elements)
            {

                listFin.Add(FirstToLast(element));
            }
            str = string.Join(" ", listFin);
            return str;
            
        }
        public static string FirstToLast(string str)
        {
            var list = new List<string> { str };
            var list2 = new List<string>();
            var list3 = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                foreach (var elem in list)
                {

                 list2.Add(elem.PadRight(elem.Length + 1, elem[0]).Remove(0, 1));
                }
                
            }
            foreach(var elem in list2)
            {

                list3.Add(AddAy(elem));
            }
          str = string.Join(" ", list3);
            return str;
        }
        public static string AddAy(string str)

        {
            char padA = 'a';
            char padY = 'y';
            str = str.PadRight(str.Length + 1, padA);
            str = str.PadRight(str.Length + 1, padY);
            return str;
        }
    }
}
