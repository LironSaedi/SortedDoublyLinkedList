using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDoublyLinkedList
{
    class LinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head;
        Node<T> Tail;
        int count = 0;
        bool checker = false;

        public void InsertIntoLinkedList(T value)
        {
            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node<T>(value);

            for (Node<T> start = Head;  current != null; current = current.Next)
            {

            }
        }
        
        private void ConnectNodes(Node<T> previous, Node<T> newNode, Node<T> next)
        {
            if (next == null)
            {
                newNode = Tail.Next;
                newNode.Previous = Tail;
                Tail = newNode;
            }
            else
            {
                previous.Next = newNode;
                newNode.Next = next;
                next.Previous = newNode;
                newNode.Previous = previous;
            }
        }
        public void Remove(T value)
        {

        }

        private void RemoveLinks(Node<T> node)
        {

        }

    }
}
