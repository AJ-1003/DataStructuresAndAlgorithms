namespace Stacks.CL
{
    public class StacksArray<T>
    {
        private T[] data;
        private int top;

        public StacksArray(int n)
        {
            data = new T[n];
            top = 0;
        }

        public int length()
        {
            return top;
        }

        public bool isEmpty()
        {
            return top == 0;
        }

        public bool isFull()
        {
            return top == data.Length;
        }

        public void push(T e)
        {
            if (isFull())
            {
                Console.WriteLine("Stack is full...");
                return;
            }
            else
            {
                data[top] = e;
                top++;
            }
        }

        public T? pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty...");
                return default;
            }
            else
            {
                var element = data[top - 1];
                top--;
                return element;
            }
        }

        public T peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty...");
                return default;
            }

            return data[top - 1];
        }

        public void display()
        {
            for (var i = 0; i< top; i++)
            {
                Console.Write($"{data[i]} --> ");
            }
            Console.WriteLine();
        }
    }
}