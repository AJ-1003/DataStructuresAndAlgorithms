using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks.CL
{
    public class StacksLinkedList<T>
    {
        private Node<T> top;
        private int size;

        public StacksLinkedList()
        {
            top = null;
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

        public void push(T e)
        {
            var newest = new Node<T>(e, null);
            
            if (isEmpty())
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }

            size++;
        }

        public T pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty...");
                return default;
            }

            var element = top.element;

            top = top.next;
            size--;

            return element;
        }

        public T peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty...");
                return default;
            }

            return top.element;
        }

        public void display()
        {
            var p = top;

            while (p != null)
            {
                Console.Write($"{p.element} --> ");
                p = p.next;
            }

            Console.WriteLine();
        }
    }
}
