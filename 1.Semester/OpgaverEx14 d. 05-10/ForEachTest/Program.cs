﻿    namespace ForEachTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[] IntArray = { 3, 2, 4, 1 };
            foreach (int number in IntArray)
            {
                IntArray[number] = 1;
            }
        }
    }
}