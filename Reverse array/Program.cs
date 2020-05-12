using System;

namespace Reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] a = new int[5];


            Console.Write("Enter numberof elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 0; i < n; i++)

            {
           Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

          Console.Write("\nThe values store into the array are : \n");
            foreach(int k in a)
            {
                Console.Write(k + " ");
            }
               Array.Reverse(a);
            Console.Write("\nReversed Array : \n");
            foreach (int j in a)
            {
                Console.Write(j + " ");
            }
        }       }
    }

