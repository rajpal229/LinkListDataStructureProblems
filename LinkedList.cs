using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class LinkedList
    {
        Node head;
        public void AddNote(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }

            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List contains");
                Console.ResetColor();
                Node tempnode = head;
                while (tempnode != null)
                {
                    Console.WriteLine("| "+tempnode.data + " |");
                    tempnode = tempnode.Next;
                }
                Console.WriteLine("\n");
            }
        }
        public void AddReverse(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.Next = temp;
            }
        }
        public void Insert(int position, int data)
        {
            Node node = new Node(data);
            if (position<1)
            {
                Console.WriteLine("Enter Valid Position");
            }
            else if (position == 1)
            {
                node.Next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                while (position > 2)
                {
                    temp = temp.Next;
                    position--;
                }
                node.Next = temp.Next;
                temp.Next = node;
            }
        }
        public void DeleteFirst()
        {
            Node node = head;
            if (head.Next != null)
            {
                node = head;
                head = head.Next;
                node = null;
            }
        }
        public void DeleteLast()
        {
            Node node = head;
            Node lastnode = node.Next;
            if (head.Next != null)
            {
                node = node.Next;
                node.Next = null;
                lastnode = null;
            }
        }
    }
}
