using System;
using System.Collections.Generic;


namespace ArrayAndCollections
{
    //  This program demo. how to use List Generics class.
    class ListGenericDemo
    {
        static void Main()
        {
            List<int> intList = new List<int>();
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            //intList.Add("hello");//Error

            foreach (var num in intList)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }

    }
}
