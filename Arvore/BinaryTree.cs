namespace Arvore
{
    public class BinaryTree
    {
        private Node root;
        public Node Root
        {
            get { return root; }
        }

        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            if (value < root.Value)
            {
                root.Left = InsertRec(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = InsertRec(root.Right, value);
            }

            return root;
        }

        public void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Value + " ");
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
        }

        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Value + " ");
                InOrderTraversal(root.Right);
            }
        }

        public void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                Console.Write(root.Value + " ");
            }
        }

        public void LevelOrderTraversal()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node tempNode = queue.Dequeue();
                Console.Write(tempNode.Value + " ");

                if (tempNode.Left != null)
                {
                    queue.Enqueue(tempNode.Left);
                }

                if (tempNode.Right != null)
                {
                    queue.Enqueue(tempNode.Right);
                }
            }
        }

        public void RemoveRandomNodes(int count)
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                int valueToRemove = random.Next(101);
                Console.WriteLine($"Removing {valueToRemove}");
                root = RemoveNode(root, valueToRemove);
            }
        }

        private Node RemoveNode(Node root, int key)
        {
            if (root == null)
                return root;

            if (key < root.Value)
                root.Left = RemoveNode(root.Left, key);
            else if (key > root.Value)
                root.Right = RemoveNode(root.Right, key);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Value = MinValue(root.Right);

                root.Right = RemoveNode(root.Right, root.Value);
            }

            return root;
        }

        private int MinValue(Node root)
        {
            int minValue = root.Value;
            while (root.Left != null)
            {
                minValue = root.Left.Value;
                root = root.Left;
            }
            return minValue;
        }
    }
}
