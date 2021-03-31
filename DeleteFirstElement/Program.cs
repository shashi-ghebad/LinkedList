using System;
using System.Collections.Generic;

namespace DeleteFirstElement
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList link = new LinkedList();
            link.Add(56);
            link.Add(70);
            link.Insert(1, 30);
            link.Display();
            link.RemoveFirstNode();
            link.Display();
            Console.ReadKey();
        }
    }
}