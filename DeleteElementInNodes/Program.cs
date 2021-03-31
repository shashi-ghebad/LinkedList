using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementInNodes
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList link = new LinkedList();
            link.Add(56);
            link.Add(30);
            link.Add(70);
            link.Insert(2, 40);
            link.Display();
            link.RemoveInBetweenNodes(2);
            link.Display();
            Console.WriteLine("The Size of Linked List is: " + link.Size());
            Console.ReadKey();
        }
    }
}