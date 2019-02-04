using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB.QueueDS
{
    class Program
    {
        static int MAX = 100;
        int FRONT = 0;
        int REAR = -1;
        int[] queue = new int[MAX];// array

        //function to insert the element in the queue
        public void Insert(int n)
        {
            //check whether the queue is empty or not
            if(FRONT>=MAX)
            {
                Console.WriteLine("The Queue is full");
            }
            else
            {
                queue[FRONT++] = n;// inserting the element in the queue 
            }
        }

        //function to delete the element from the queue
        public void Delete()
        {
            //check whether the queue has an element to delete
            if(FRONT== REAR+1)
            {
                Console.WriteLine("The queue is empty");
            }
            else
            {
                Console.WriteLine("The deleted element is: " + queue[++REAR]);//deleting the element 
            }
        }

        //function to display the queue
        public void Display()
        {
            //check whether the elemets are present in the queue or not
            if (FRONT == REAR + 1)
            {
                Console.WriteLine("The queue is empty");
            }
            else
            {
                //displaying the queue
                Console.WriteLine("The current elements in the Queue");
                for (int i = 0; i < MAX; ++i)
                {
                    Console.WriteLine(queue[i]);
                }
            }
            
        }

        static void Main(string[] args)
        {
            Program ob = new Program();// object to call the functions
            while (true)
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1. Insert the element in the queue");
                Console.WriteLine("2. Delete the element from the queue");
                Console.WriteLine("3. Display the queue");
                Console.WriteLine("4. Exit");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the element to be inserted");
                            int num = Convert.ToInt32(Console.ReadLine());
                            ob.Insert(num);
                            break;
                        }

                    case 2:
                        {
                            ob.Delete();
                            break;
                        }

                    case 3:
                        {
                            ob.Display();
                            break;
                        }
                    case 4:
                        {
                            Environment.Exit(0);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }
                }
                Console.ReadKey();
            }
            
        }
    }
}
