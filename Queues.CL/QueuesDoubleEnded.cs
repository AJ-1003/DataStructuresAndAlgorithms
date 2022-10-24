using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.CL
{
    public class QueuesDoubleEnded<T>
    {
        private Node<T> front;
        private Node<T> rear;
        private int size;

        public QueuesDoubleEnded()
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

        public void addFirst(T e)
        {
            var newest = new Node<T>(e, null);

            if (isEmpty())
            {
                front = newest;
                rear = newest;
            }
            else
            {
                newest.next = front;
                front = newest;
            }

            size++;
        }

        public void addLast(T e)
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

        public T removeFirst()
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

        public T removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty...");
            }

            var p = front;
            var i = 1;

            while (i < size - 1)
            {
                p = p.next;
                i++;
            }

            rear = p;
            p = p.next;

            var element = p.element;
            
            rear.next = null;
            size--;

            return element;
        }

        public int search(Node<T> key)
        {
            var p = front;
            var index = 0;

            while (p != null)
            {
                if (p.element.Equals(key.element))
                {
                    return index;
                }

                p = p.next;
                index++;
            }

            return -1;
        }

        public void display()
        {
            var p = front;

            while (p != null)
            {
                Console.WriteLine($"{p.element} --> ");
                p = p.next;
            }

            Console.WriteLine();
        }

        public T first()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty...");
                return default;
            }

            return front.element;
        }

        public T last()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty...");
                return default;
            }

            return rear.element;
        }
    }
}
