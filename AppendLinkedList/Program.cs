using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList link = new LinkedList();
            link.Add(56);
            link.Add(30);
            link.Add(70);
            link.Display();
            Console.ReadKey();
        }
    }
}