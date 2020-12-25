using System;
using System.Collections.Generic;

namespace Day15_LinkedLists
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    public class Solution
    {
        public static Node insert(Node head, int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return head;
            }

            Node start = head;

            while (start.next != null)
            {
                start = start.next;
            }

            start.next = new Node(data);
            return head;
        }
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            LinkedListNode<int> currentNode = new LinkedListNode<int>(data[0]);

            list.AddFirst(currentNode);

            foreach (var item in data.Skip(1))
            {
                currentNode = list.AddAfter(currentNode, item);
            }
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
