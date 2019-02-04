using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB.DFS
{
    class DepthFirstSearch
    {
        private Node root = null;
        public void DisplayDSF(Node root)
        {
            if (root == null)
                return;

            else
            {
                DisplayDSF(root.left);
                Console.WriteLine(root.data);
                DisplayDSF(root.right);
            }
        }
        static void Main(string[] args)
        {
            DepthFirstSearch ob = new DepthFirstSearch();
            try
            {
                ob.root = new Node(2);
                ob.root.left = new Node(4);
                ob.root.right = new Node(6);
                ob.root.left.left = new Node(8);
                ob.root.left.right = new Node(10);
                ob.root.right.left = new Node(12);

                Console.WriteLine("BFS traversal of binary tree is: ");
                ob.DisplayDSF(ob.root);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }

    class Node
    {
        public int data;
        public Node left, right;

        public Node(int d)
        {
            data = d;
            left = right = null;
        }
    }
}
