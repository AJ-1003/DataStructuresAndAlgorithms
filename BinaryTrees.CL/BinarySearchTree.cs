using Queues.CL;

namespace BinaryTrees.CL
{
    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void insertWithNoReference(Node tempRoot, int e)
        {
            Node temp = null;

            while (tempRoot != null)
            {
                temp = tempRoot;

                if (e == tempRoot.element)
                {
                    return;
                }
                else if (e < tempRoot.element)
                {
                    tempRoot = tempRoot.left;
                }
                else if (e > tempRoot.element)
                {
                    tempRoot = tempRoot.right;
                }
            }

            var n = new Node(e, null, null);

            if (root != null)
            {
                if (e < temp.element)
                {
                    temp.left = n;
                }
                else
                {
                    temp.right = n;
                }
            }
            else
            {
                root = n;
            }
        }

        public Node insertWithReference(Node tempRoot, int e)
        {
            if (tempRoot != null)
            {
                if (e < tempRoot.element)
                {
                    tempRoot.left = insertWithReference(tempRoot.left, e);
                }
                else if (e > tempRoot.element)
                {
                    tempRoot.right = insertWithReference(tempRoot.right, e);
                }
            }
            else
            {
                var n = new Node(e, null, null);
                tempRoot = n;
            }

            return tempRoot;
        }

        public bool delete(int e)
        {
            Node p = root;
            Node pp = null;

            while (p != null && p.element != e)
            {
                pp = p;

                if (e < p.element)
                {
                    p = p.left;
                }
                else
                {
                    p = p.right;
                }
            }

            if (p == null)
            {
                return false;
            }

            if (p.left != null && p.right != null)
            {
                var s = p.left;
                var ps = p;

                while (s.right != null)
                {
                    ps = s;
                    s = s.right;
                }

                p.element = s.element;
                p = s;
                pp = ps;
            }

            Node c = null;

            if (p.left != null)
            {
                c = p.left;
            }
            else
            {
                c = p.right;
            }

            if (p == root)
            {
                root = null;
            }
            else
            {
                if (p == pp.left)
                {
                    pp.left = c;
                }
                else
                {
                    pp.right = c;
                }
            }

            return true;
        }

        public int count(Node tempRoot)
        {
            if (tempRoot != null)
            {
                var x = count(tempRoot.left);
                var y = count(tempRoot.right);
                return x + y + 1;
            }

            return 0;
        }

        public int height(Node tempRoot)
        {
            if (tempRoot != null)
            {
                var x = height(tempRoot.left);
                var y = height(tempRoot.right);

                if (x > y)
                {
                    return x + 1;
                }
                else
                {
                    return y + 1;
                }
            }

            return 0;
        }

        public void preOrder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                Console.Write($"{tempRoot.element} ");
                preOrder(tempRoot.left);
                preOrder(tempRoot.right);
            }
        }

        public void inOrder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                inOrder(tempRoot.left);
                Console.Write($"{tempRoot.element} ");
                inOrder(tempRoot.right);
            }
        }

        public void postOrder(Node tempRoot)
        {
            if (tempRoot != null)
            {
                postOrder(tempRoot.left);
                postOrder(tempRoot.right);
                Console.Write($"{tempRoot.element} ");
            }
        }

        public void levelOrder()
        {
            var q = new QueuesLinkedList<Node>();
            var t = root;

            Console.WriteLine($"{t.element}");
            q.enqueue(t);

            while (!q.isEmpty())
            {
                t = q.dequeue();

                if (t.left != null)
                {
                    Console.Write($"{t.left.element} ");
                    q.enqueue(t.left);
                }

                if (t.right != null)
                {
                    Console.Write($"{t.right.element} ");
                    q.enqueue(t.right);
                }
            }
        }

        public bool search(Node tempRoot, int key)
        {
            if (tempRoot != null)
            {
                if (key == tempRoot.element)
                {
                    return true;
                }
                else if (key < tempRoot.element)
                {
                    return search(tempRoot.left, key);
                }
                else if (key > tempRoot.element)
                {
                    return search(tempRoot.right, key);
                }
            }

            return false;
        }
    }
}