using System;
using System.Collections.Generic;
using System.IO;

namespace FirstTraining2
{
    class Program
    {
        public static void Count(IDictionary<char, int> dic, string text)
        {
            foreach (char c in text)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c] += 1;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }
        }
        public static void Display(IDictionary<char, int> dic, string text)
        {
            Console.WriteLine("\nCharacters:");
            foreach (var element in dic)
            {
                if (element.Value > 1)
                {
                    Console.WriteLine($"{element.Key}: {element.Value} times");
                }
                else
                {
                    Console.WriteLine($"{element.Key}: {element.Value} time");
                }
            }
        }
        static void Main(string[] args)
        {
            string textFile1 = @"C:\Users\vbalaban\source\repos\FirstTraining2\FirstTraining2\file.txt";
            string textFile2 = @"C:\Users\vbalaban\source\repos\FirstTraining2\FirstTraining2\file2.txt";
            string text = File.ReadAllText(textFile1);

            Console.WriteLine($"Text from file is \n,,{text},,");


            Dictionary<char, int> Dict = new Dictionary<char, int>();
            SortedDictionary<char, int> SortDict = new SortedDictionary<char, int>();

            Count(Dict, text);
            Display(Dict, text);

            text = File.ReadAllText(textFile2);

            Count(SortDict, text);
            Display(SortDict, text);
        }
    }
}
