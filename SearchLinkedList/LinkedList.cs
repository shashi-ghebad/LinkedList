﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchLinkedList
{
    public class LinkedList
    {
        internal Node head; //new 
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
            Console.WriteLine();
        }

        internal Node Insert(int pos, int data)
        {
            Node node = new Node(data);
            Node temp1 = head;
            Node temp2 = head;
            if (pos == 0)
            {
                node.next = head;
                head = node;
                return head;
            }
            else if (pos < 0)
            {
                Console.WriteLine("Invalid Position");
                return head;
            }
            else
            {
                int count = 0;
                while (count != pos - 1)
                {
                    temp1 = temp1.next;
                    count++;
                }
                count = 0;
                while (count != pos)
                {
                    temp2 = temp2.next;
                    count++;
                }
            }
            temp1.next = node;
            node.next = temp2;
            Console.WriteLine("Node is inserted at position {0} with Value of {1}", pos, node.data);
            return head;
        }

        internal Node RemoveFirstNode()
        {
            if (head == null)
            {
                return null;
            }
            head = head.next;
            Console.Write("\n");
            return head;
        }

        internal Node RemoveLastNode()
        {
            Node temp = head;
            Node preNode = head;
            if (head == null)
            {
                return null;
            }
            while (temp.next != null)
            {
                preNode = temp;
                temp = temp.next;
            }
            preNode.next = null;
            Console.WriteLine();
            return head;
        }

        public bool Search(int data)
        {
            Node temp = head;
            while (temp.next != null)
            {
                if (temp.data == data)
                {
                    Console.WriteLine("The Value of {0} is present in the Linked List", data);
                    return true;
                }
                temp = temp.next;
                if (temp.next == null)
                {
                    Console.WriteLine("The Value of {0} is not present in the Linked List", data);
                }
            }
            return false;
        }

    }

}