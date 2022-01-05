using System;
using static System.Console;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            //IndexOf()
            WriteLine("Indexof 'Good': {0}", greeting.IndexOf("Good"));
            WriteLine("Indexof 'o': {0}", greeting.IndexOf('o'));

            //LastIndexOf()
            WriteLine("LastIndexOf 'Good': {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o': {0}", greeting.LastIndexOf("o"));

            //StartsWith()
            WriteLine("StartsWith 'Good': {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith 'Morning': {0}", greeting.StartsWith("Morning"));

            //EndsWith()
            WriteLine("EndsWith 'Good': {0}", greeting.EndsWith("Good"));
            WriteLine("EndsWith 'Morning': {0}", greeting.EndsWith("Morning"));

            //Contains()
            WriteLine("Containts 'Evening': {0}", greeting.Contains("Evening"));
            WriteLine("Containts 'Morning': {0}", greeting.Contains("Morning"));

            //Replace()
            WriteLine("Replaced 'Morning' with 'Evening': {0}", greeting.Replace("Morning", "Evening"));
        }
    }
}