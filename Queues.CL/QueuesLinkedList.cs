using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.CL
{
    public class QueuesLinkedList<T>
    {
        private Node<T> front;
        private Node<T> rear;
        private int size;

        public QueuesLinkedList()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void enqueue(T e)
        {
            var newest = new Node<T>(e, null);

            if (isEmpty())
            {
                front = newest;
            }
            else
            {
                rear.next = newest;
            }

            rear = newest;
            size++;
        }

        public T dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty...");
                return default;
            }

            var element = front.element;

            front = front.next;
            size--;

            if (isEmpty())
            {
                rear = null;
            }

            return element;
        }

        public void display()
        {
            var p = front;

            while (p != null)
            {
                Console.Write($"{p.element} --> ");
                p = p.next;
            }

            Console.WriteLine();
        }
    }
}
