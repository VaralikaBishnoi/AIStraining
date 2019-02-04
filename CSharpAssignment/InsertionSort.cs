using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB.InsertionSort
{
    class Program
    {
        public static void Isort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int j = i - 1;
                int temp = a[i];

                while (j >= 0 && temp < a[j])
                {
                    a[j + 1] = a[j];
                    j--; ;
                }

                a[j + 1] = temp;
            }

            Console.WriteLine("Sorted Elements");
            for (int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length for the array");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[len];
            Console.WriteLine("Enter " + len + " elements in the array");
            for (int i = 0; i < len; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
            Isort(arr);
        }
    }
}
