using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Heap
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] values = new int[] { 15, 9, 8, 1, 4, 11, 7, 12, 13, 6, 5, 3, 16, 2, 10 };

            BuildHeap(values);

            Console.WriteLine("Hello World!");
            PrintHeap(values);
        }

        static void BuildHeap(int[] values)
        {
            int firstParent = values.Length / 2;

            int leftChild = firstParent * 2 + 1;
            int rightChild = firstParent * 2 + 2;

            Console.Write(values[leftChild - 1]);

        }

        static void PrintHeap(int[] values)
        {
            double level = Math.Log((double)values.Length, 2);

            int cursor = 0;

            for (int i = 0; i < level; i++)
            {
                for (int j = (int)Math.Pow(2, i); j < Math.Pow(2, i + 1); j++)
                {
                    Console.Write(values[cursor] + " ");
                    cursor++;
                }

                Console.WriteLine("level : " + (int)Math.Pow(2, i));
            }
        }
    }
}
