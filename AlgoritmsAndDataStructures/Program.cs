using System;

namespace AlgoritmsAndDataStructures
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            IterateOver(new []{1,2,3}); 
            Console.Read();
        }

        private static unsafe void IterateOver(int[] array)
        {
            fixed (int* b = array)
            {
                int* p = b;
                
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(*p);
                    p++;
                }
            }
        }

        private static void ArraysDemo()
        {
            int[] a1;
            a1 = new int[10];
            
            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

            int[] a4 = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < a3.Length; i++)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine();

            foreach (var el in a4)
            {
                Console.WriteLine($"{el}");
            }
            
            Console.WriteLine();
            
            Array myArray = Array.CreateInstance(typeof(int),5);
            myArray.SetValue(1,0);

            Console.Read();

        }

        private static void Test1BasedArray()
        {
            Array myArray = Array.CreateInstance(typeof(int), new []{4}, new []{1});
            myArray.SetValue(1,1);
            myArray.SetValue(2,2);
            myArray.SetValue(3,3);
            myArray.SetValue(4,4);
            
            Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending index: {myArray.GetUpperBound(0)}");
        }
        
        private static void MultiDimArrays()
        {
            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            
            int[,] r2 =  { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.WriteLine($"{r2[i,j]}");
                }
                Console.WriteLine();
            }
            
            
        }

        private static void JaggedArraysDemo()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[3];
            jaggedArray[3] = new int[4];
            
            Console.WriteLine("Enter the numbers for a jagged array");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(st);
                } 
            }

            Console.WriteLine("");
            Console.WriteLine("Printing elements");
            
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);
                    Console.Write("\0");
                }

                Console.WriteLine();
            }

        }

    }
}