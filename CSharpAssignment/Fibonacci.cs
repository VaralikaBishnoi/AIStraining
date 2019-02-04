using System;

namespace VB.Fibbonacci
{
    class Program
    {
        //function to check prime number
        static int Prime(int x)
        {
            int count = 0;//counter
            for (int i = 2; i <= x / 2; i++)
            {
                //check for prime number
                if (x % i == 0)
                {
                    count += 1;
                    break;//terminating the loop
                }

            }
            //check for prime
            if (count == 0)
                return 1;//return 1 if number is prime
            else
                return 0;//return 0 if number is not prime
        }

        //Fibonacci series
        static void Fibo(int n)
        {
            int num = 0, num1 = 1, sum = 0;
            //printing first 2 number of series
            Console.Write(num + " ");

            Console.Write(1 + " ");
            // loop to print fibonacci series upto the user entered length
            for (int i = 2; i < n; ++i)
            {
                sum = num + num1;
                num = num1;
                num1 = sum;
                if (sum == 1)
                    Console.Write(sum + " ");
                else
                {
                    //calling the function to check for prime number
                    int num2 = Prime(sum);
                    if (num2 == 1)
                        Console.Write("Prime ");
                    else
                        Console.Write(sum + " ");
                }
            }
            //Console.ReadKey();
        }
        static void Main(string[] args)
        {
            try                                 //a check for non-numeric user input
            {
                Console.WriteLine("Enter the length of fibbonacci series");//user input
                int len = Convert.ToInt32(Console.ReadLine());// string to int conversion

                
                if (len<=0)
                    Console.Write("Invalid input");
                else if (len == 1)
                    Console.Write(0);
                else
                    Fibo(len);// calling the function

                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.Write("Exception: "+e.Message);// displaying the exception
                Console.ReadKey();
            }
        }
    }
}


