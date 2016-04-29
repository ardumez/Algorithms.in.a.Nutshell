using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Quick
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] values = new int[] { 15, 9, 8, 1, 4, 11, 7, 12, 13, 6, 5, 3, 16, 2, 10, 14 };
            int left = 0;
            int right = values.Length - 1;

            QuickSort(values, left, right);

            Console.ReadKey();
        }

        public static void QuickSort(int[] values, int left, int right)
        {
            Console.WriteLine("Right:" + values[right]);
            Console.WriteLine("Left:" + values[left]);

            if (right - left <= 1)
                return;

            int pivot = right;

            swap(values, right, pivot);

            int store = left;

            Debug(values, left, right);
            for (int i = left; i < right; i++)
            {
                if (values[i] < values[right])
                {
                    swap(values, i, store);
                    store++;
                }
                //  Debug(values, left, right);
                //     
            }
            Console.WriteLine("End");
            swap(values, store, right);
            Debug(values);

            QuickSort(values, left, store - 1);
            QuickSort(values, store, right);

            // Debug(values);
        }

        public static void Debug(int[] values, string message = "")
        {
            Console.WriteLine("------------------- " + message);
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i].ToString() + " ");
            }
            Console.WriteLine("");
        }

        public static void Debug(int[] values, int left, int right, string message = "")
        {
            Console.WriteLine("------------------- " + message);
            for (int i = left; i < right; i++)
            {
                Console.Write(values[i].ToString() + " ");
            }
            Console.WriteLine("");
        }

        public static void swap(int[] values, int pos, int targetPos)
        {
            int posValue = values[pos];
            values[pos] = values[targetPos];
            values[targetPos] = posValue;
        }
    }
}
