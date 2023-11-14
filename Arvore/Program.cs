namespace Arvore
{
    class Program
    {
        static void Main()
        {
            BinaryTree tree = new BinaryTree();
            Random random = new Random();

            Console.WriteLine("Inserindo 20 números aleatórios na árvore:");

            for (int i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(101);
                tree.Insert(randomNumber);
                Console.Write(randomNumber + " ");
            }

            Console.WriteLine("\n\nSequência de pré-ordem:");
            tree.PreOrderTraversal(tree.Root);

            Console.WriteLine("\n\nSequência de in-ordem:");
            tree.InOrderTraversal(tree.Root);

            Console.WriteLine("\n\nSequência de pós-ordem:");
            tree.PostOrderTraversal(tree.Root);

            Console.WriteLine("\n\nSequência em nível:");
            tree.LevelOrderTraversal();

            Console.WriteLine("\n\nRemovendo 5 elementos aleatórios:");

            tree.RemoveRandomNodes(5);

            Console.WriteLine("\n\nSequência de pré-ordem após remoção:");
            tree.PreOrderTraversal(tree.Root);

            Console.WriteLine("\n\nSequência de in-ordem após remoção:");
            tree.InOrderTraversal(tree.Root);

            Console.WriteLine("\n\nSequência de pós-ordem após remoção:");
            tree.PostOrderTraversal(tree.Root);

            Console.WriteLine("\n\nSequência em nível após remoção:");
            tree.LevelOrderTraversal();
        }
    }
}
