namespace Heaps.CL
{
    public class Heap
    {
        int[] data;
        int maxSize;
        int cSize;

        public Heap()
        {
            maxSize = 10;
            data = new int[maxSize];
            cSize = 0;

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = -1;
            }
        }

        public int length()
        {
            return cSize;
        }

        public bool isEmpty()
        {
            return cSize == 0;
        }

        public void insert(int e)
        {
            if (cSize == maxSize)
            {
                Console.WriteLine("Heap is full...");
                return;
            }

            cSize++;

            var hi = cSize;

            while (hi > 1 && e > data[hi / 2])
            {
                data[hi] = data[hi / 2];
                hi = hi / 2;
            }

            data[hi] = e;
        }

        public int max()
        {
            if (isEmpty())
            {
                Console.WriteLine("Heap is empty...");
                return -1;
            }

            return data[1];
        }

        public void display()
        {
            for (var i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"{data[i]} ");
            }

            Console.WriteLine();
        }
    }
}