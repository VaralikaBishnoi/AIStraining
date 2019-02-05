using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB.BinarySearchTree
{
    class BST
    {
         Node root = null;  //Class Type variable

        //displays the tree 
        public void DisplayBST(Node root)
        {
            if (root == null)
                return;

            else
            {
                //inorder traversal 
                DisplayBST(root.left);// recursive call
                Console.WriteLine(root.data);
                DisplayBST(root.right);// recursive call
            }
        }

        // Input the element in the tree from user
        public void Insert(int d)
        {
            Node newnode = new Node(); //Class type object
            newnode.data = d;

            if (root == null)
                root = newnode;

            else
            {
                Node current = root;
                Node parent;

                while(true)
                {
                    parent = current;
                    //if data given by user is less than current data then go to left of the root
                    if(d<current.data)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newnode;
                            break;
                        }
                    }
                    
                    //if data given by the user is greater than current data then go to right if the root
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newnode;
                            break;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            BST ob = new BST(); //object
            char ch = 'Y';

            // error handlling
            try
            {
                while (ch == 'Y')
                {
                    Console.WriteLine("Enter the number to be added to the tree ");// user input
                    int d = Convert.ToInt32(Console.ReadLine());

                    ob.Insert(d);

                    Console.WriteLine("To continue Press Y else Press N");//user choice to continue with the input
                    ch = Convert.ToChar(Console.ReadLine());
                }

                Console.WriteLine("Tree Traversal");
                ob.DisplayBST(ob.root);// function call 
                Console.ReadKey();
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);// prints the error if occurs
            }

        }
    }

    class Node      
    {
        public Node left, right;
        public int data;
    }
}
