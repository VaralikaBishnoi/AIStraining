using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB.MergeSort
{
    class Program
    {

        public int[] Merge(int[] a, int left, int midd, int right)
        {
            int num1 = midd - left + 1;
            int num2 = right - midd;
            int[] arrTemp1 = new int[num1];
            int[] arrTemp2 = new int[num2];
            int i,j,k; 

            for( i= 0;i<num1;i++)
            {
                arrTemp1[i] = a[left + i];
            }
            for( i = 0;i<num2;++i)
            {
                arrTemp2[i] = a[midd + 1 + i];
            }

            i = 0;
            j = 0;  
            k = left;
            
            while(i<num1&&j<num2)
            {
                if(arrTemp1[i]<arrTemp2[j])
                {
                    a[k] = arrTemp1[i];
                    i++;
                }
                else
                {
                    a[k] = arrTemp2[j];
                    j++;
                }
                k++;
            }

            while(i<num1)
            {
                a[k] = arrTemp1[i];
                i++;
                k++;
            }

            while(j<num2)
            {
                a[k] = arrTemp2[j];
                j++;
                k++;
            }
            return a;
        }
        public int[] mergeSort(int[] array,  int l, int r)
        {
            int[] newArr = new int[l+r];
            if(l<r)
            {
                int mid = (l + r) / 2;
                mergeSort(array, l, mid);
                mergeSort(array, mid + 1, l);
                newArr= Merge(array, l, mid, r);

            }
            return newArr;
            
        }
        static void Main(string[] args)
        {

            Program ob = new Program();
            Console.WriteLine("Enter the length of the array");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[len];
            int[] arr1 = new int[len];
            Console.WriteLine("Enter " + len + " elements in the array");
            for(int i =0;i<len;++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array before Merge Sort");
            for(int i=0;i<len;++i)
            {
                Console.WriteLine(arr[i]);
            }

            arr = ob.mergeSort(arr,  0, len - 1);

            Console.WriteLine("Array after Merge Sort");
            for(int i=0;i<len;++i)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
