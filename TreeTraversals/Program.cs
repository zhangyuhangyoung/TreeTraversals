using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeTraversals
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = null;
            right = null;
        }
    }

    public class Tree
    {
        // Root of Binary Tree 
        public Node root;

        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void printPostorder(Node node)
        {
            if (node == null)
                return;

            printPostorder(node.left);
            printPostorder(node.right);

            Console.Write(node.key + " ");
        }

        public void printInorder(Node node)
        {
            if (node == null)
                return;

            printInorder(node.left);
            Console.Write(node.key + " ");
            printInorder(node.right);
        }

        public void printPreorder(Node node)
        {
            if (node == null)
                return;

            Console.Write(node.key + " ");

            printPreorder(node.left);

            printPreorder(node.right);
        }
    }
    static class Program
    {
        /// <summary>
            [STAThread]
        static void Main()
        {
            Tree tree = new Tree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Preorder traversal " +
                               "of binary tree is ");
            tree.printPreorder(tree.ReturnRoot());

            Console.WriteLine("\nInorder traversal " +
                                "of binary tree is ");
            tree.printInorder(tree.ReturnRoot());
            Console.WriteLine("\nPostorder traversal " +
                                  "of binary tree is ");
            tree.printPostorder(tree.ReturnRoot());

            Console.WriteLine("\n ");
        }
    }
}
