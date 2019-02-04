using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB.BFS
{
    class BreadthFirstSearch
    {
        private Node root=null;

        public int height(Node root)
        {
            if(root == null)
                return 0;

            else{
                int leftHeight = height(root.left);
                int rightHeight = height(root.right);

                if (leftHeight > rightHeight)
                    return (leftHeight + 1);
                else
                    return (rightHeight + 1);
            }
        }

        public void treeTraversal(Node root, int level)
        {
            if (root == null)
                return;
            if (level == 0)
                Console.WriteLine(root.data);

            else
            {
                treeTraversal(root.left, level - 1);
                treeTraversal(root.right, level - 1);
            }
        }
        public void DisplayBFS(Node root)
        {
            int h = height(root);
            for(int i =0;i<h;++i)
            {
                treeTraversal(root, i);
            }
        }



        static void Main(string[] args)
        {
            BreadthFirstSearch ob = new BreadthFirstSearch();
            try
            {
                ob.root = new Node(2);
                ob.root.left = new Node(4);
                ob.root.right = new Node(6);
                ob.root.left.left = new Node(8);
                ob.root.left.right = new Node(10);
                ob.root.right.left = new Node(12);

                Console.WriteLine("BFS traversal of binary tree is: ");
                ob.DisplayBFS(ob.root);
            }

            catch(Exception e)
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
