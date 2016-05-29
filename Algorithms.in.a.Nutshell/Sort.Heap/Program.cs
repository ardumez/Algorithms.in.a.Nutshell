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
            SortHeapV1 sort = new SortHeapV1();
 
            Console.ReadLine();
        }
    }


    public class SortHeapV1
    {
        int[] values;

        public SortHeapV1()
        {
            values = new int[] { 15, 9, 8, 1, 4, 11, 7, 12, 13, 6, 5, 3, 16, 2, 10 };

            for (int i = 0; i < values.Length; i++)
            {
                BuildHeap(i);
            }
        }

        void BuildHeap(int alreadySort)
        {
            int sizeSort = values.Length - alreadySort;
            int firstParent = (sizeSort / 2);

            for (int i = firstParent; i > 0; i--)
            {
                Sort(i, alreadySort);
            }
        }

        void Sort(int i, int alreadySort)
        {
            int leftChild = (i * 2);
            int rightChild = (i * 2 + 1);

            if (leftChild <= (values.Length - alreadySort))
            {
                if (values[i + alreadySort - 1] < values[leftChild + alreadySort - 1])
                {
                    Swap(leftChild + alreadySort - 1, i + alreadySort - 1);
                    Sort(leftChild, alreadySort);
                }
            }
            if (rightChild <= values.Length - alreadySort)
            {
                if (values[i + alreadySort - 1] < values[rightChild + alreadySort - 1])
                {
                    Swap(rightChild + alreadySort - 1, i + alreadySort - 1);
                    Sort(rightChild, alreadySort);
                }
            }
        }

        void Swap(int i, int j)
        {
            int val = values[i];
            values[i] = values[j];
            values[j] = val;
        }
    }
}
