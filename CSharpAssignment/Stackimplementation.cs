using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB.StackDS
{
    class Program
    {
        static int MAX = 100;   //global variable
        int TOP = -1;           
        int[] stack = new int[MAX];

        //function to push the element in the stack
        public void Push(int n)
        {
            //check whether the stack is empty for not
            if(TOP>=MAX)
            {
                Console.WriteLine("Stack is Full");
            }

            else
            {
                stack[++TOP] = n;// pushing the element in the stack
            }
        }

        //function to pop out theelement from the stack
        public void Pop()
        {
            //check whether the stack has elements
            if(TOP<0)
            {
                Console.WriteLine("Stack is empty");
            }

            else
            {
                Console.WriteLine("The popped element is: " + stack[TOP--]);// pop out the element from the stack
            }
        }

        //function to display the elements present in the stack
        public void Display()
        {
            //check whether the stack has the elements to display or not
            if (TOP < 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                //printing the stack elements
                Console.WriteLine("The current elements in the stack are: ");
                for (int i = 0; i < TOP; ++i)
                {
                    Console.WriteLine(stack[i]);
                }
            }
           
        }
         static void Main(string[] args)
        {
            

            Program ob = new Program();// object to call the functions
            
            while (true)
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1. Push the element in the Stack");
                Console.WriteLine("2. Pop the element from the Stack");
                Console.WriteLine("3. Display the Stack");
                Console.WriteLine("4. Exit");
                int ch = Convert.ToInt32(Console.ReadLine());

                //user choice
                switch (ch)
                {
                    case 1:
                        {
                            //error handlling
                            try
                            {
                                Console.WriteLine("Enter the number to be pushed");
                                int num = Convert.ToInt32(Console.ReadLine());
                                ob.Push(num);// calling the function Push()
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            
                            
                            break;
                        }

                    case 2:
                        {
                            ob.Pop();// calling the function Pop()
                            break;
                        }

                    case 3:
                        {
                            ob.Display();// calling the function Display()
                            break;
                        }

                    case 4:
                        {
                            Environment.Exit(0);// exits the system
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid choice");
                            break;
                        }
                }

                Console.ReadKey();
            }
            
        }
    }
}
