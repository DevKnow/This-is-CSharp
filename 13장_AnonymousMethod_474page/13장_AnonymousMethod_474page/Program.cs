using System;

namespace _13장_AnonymousMethod_474page
{
    delegate int Compare(int a, int b);

    class Program
    {
        static void BubbbleSort(int[] DataSet, Compare comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for(i=0; i<DataSet.Length-1; i++)
            {
                for(j=0; j<DataSet.Length-(i+1); j++)
                {
                    if(comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbbleSort(arr, delegate (int a, int b)
            {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"{arr[i]} ");

            int[] arr2 = { 7, 2, 8, 10, 11 };

            Console.WriteLine("\nSorting descending...");
            BubbbleSort(arr2, delegate (int a, int b)
            {
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < arr2.Length; i++)
                Console.WriteLine($"{arr2[i]} ");
        }
    }
}