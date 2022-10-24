namespace Queues.CL
{
    public class QueuesArray<T>
    {
        private T[] data;
        private int front;
        private int rear;
        private int size;

        public QueuesArray(int n)
        {
            data = new T[n];
            front = 0;
            rear = 0;
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

        public bool isFull()
        {
            return size == data.Length;
        }

        public void enqueue(T e)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is full...");
                return;
            }
            else
            {
                data[rear] = e;
                rear++;
                size++;
            }
        }

        public T dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty...");
                return default;
            }
            else
            {
                var element = data[front];

                front++;
                size--;

                return element;
            }
        }

        public void display()
        {
            for (var i = front; i < rear; i++)
            {
                Console.WriteLine($"{data[i]} --> ");
            }
            Console.WriteLine();
        }
    }
}