using System;
using System.IO;

namespace Vitamin18_1_621page
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream inStream = new FileStream("a.dat", FileMode.Open);
            for(int i=0; i<3; i++)
                Console.Write($"{inStream.ReadByte():00} ");
            inStream.Seek(5, SeekOrigin.Current);
            Console.Write($"{inStream.ReadByte():00} ");
        }
    }
}