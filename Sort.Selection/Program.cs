using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 15, 9, 8, 1, 4, 11, 7, 12, 13, 6, 5, 3, 16, 2, 10, 14 };

            for (int length = values.Length - 1; length >= 0; length--)
            {
                int maxPos = 0;
                for (int i = 0; i <= length; i++)
                {
                    if (values[i] > values[maxPos])
                    {
                        maxPos = i;
                    }
                }

                Swap(values, maxPos, length);
                Debug(values);
            }
        }

        static void Debug(int[] values, string message = "")
        {
            Console.WriteLine("------------------- " + message);
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i].ToString() + " ");
            }
            Console.WriteLine("");
        }

        static void Swap(int[] values, int pos, int targetPos)
        {
            int posValue = values[pos];
            values[pos] = values[targetPos];
            values[targetPos] = posValue;
        }
    }
}
