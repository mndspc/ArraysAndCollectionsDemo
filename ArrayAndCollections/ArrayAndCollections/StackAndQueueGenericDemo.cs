using System;
using System.Collections.Generic;


namespace ArrayAndCollections
{
    //  This program demo. how to declare Queue Generic and Stack Generic.
    class StackAndQueueGenericDemo
    {
        static void Main()
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(20);

            Stack<string> strStack = new Stack<string>();
            strStack.Push("welcome");
            strStack.Push("to stack");

        }
    }
}
