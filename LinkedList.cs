using System;

namespace kelly_linkedlist
{
    class LinkedList
    {
        private Node head;
        public string GetFirst()
        {
            if (head != null)
            {
                return head.data;
            }
            else
            {
                return "Your list is empty.";

            }
        }
        public void AddFirst(string data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node newHead = new Node(data)
                {
                    next = head
                };
                head = newHead;
            }
        }
        public Node Contains(string data)
        {
            if (head == null)
            {
                return null;
            }
            else
            {
                Node current = head;
                while (current.data != data)
                {
                    current = current.next;
                    if (current == null)
                    {
                        return null;
                    }
                }
                return current;
            }
        }
        public void Remove(string data)
        {
            Node current = head;
            while (current != null)
            {
                Node nextNode = current.next;
                if (current.data == data)
                {
                    head = nextNode;
                    break;
                }
                if (nextNode.data == data)
                {
                    current.next = nextNode.next;
                    break;
                }
                current = current.next;
            }
        }
        public void Add(string data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data);
            }
        }
        public void PrintAllNodes()
        {
            Node current = head;
            if (current == null)
            {
                Console.WriteLine("Your list is empty.");
            }
            else
            {
                while (current.next != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
                Console.WriteLine(current.data);
            }
        }
    }
}
