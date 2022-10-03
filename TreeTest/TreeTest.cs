using BinaryTreeLibrary;

namespace TreeTest
{
    internal class TreeTest
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            Console.WriteLine("Inserting values: ");
            Random random = new Random();

            // Insert 10 random integers from 0-99 in tree
            for (var i = 1; i <= 10; i++)
            {
                int insertValue = random.Next(100);
                Console.Write($"{insertValue} ");

                tree.InsertNode(insertValue);   
            }

            // Perform preorder traversal of tree
            Console.WriteLine("\n\nPreorder Traversal");
            tree.PreorderTraversal();

            // Perform inorder traversal of tree
            Console.WriteLine("\n\nInorder Traversal");
            tree.InorderTraversal();

            // Perform preorder traversal of tree
            Console.WriteLine("\n\nPostorder Traversal");
            tree.PostorderTraversal();

            Console.WriteLine();
        }
    }
}