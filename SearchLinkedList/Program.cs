
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList link = new LinkedList();
            link.Add(56);
            link.Add(70);
            link.Insert(1, 30);
            link.Display();
            link.Search(30);
            Console.ReadKey();
        }
    }
}