﻿using System;

namespace ArrayAndCollections
{
    //  This program demo. how to work with multi dim. array.
    class MultiDimArray
    {
        static void Main()
        {
            int[,] numsArray = { { 12,45,55},{56,67,88 } };

            int[,] numsArray1 = new int[2,3];
            Console.WriteLine("Please Enter 6 elements:");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    numsArray1[i, j]=int.Parse( Console.ReadLine());
                }
            }

            Console.WriteLine("You have entered elements as below:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{numsArray1[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
