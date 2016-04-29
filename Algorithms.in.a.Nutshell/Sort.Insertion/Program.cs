using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 8, 10, 1, 5, 7 };

            for (int increment = 0; increment < values.Length - 1; increment++)
            {
                // Move on left while current is min of left values
                for (int decrement = increment; decrement >= 0; decrement--)
                {
                    int rightValue = values[decrement + 1];
                    int currentValue = values[decrement];

                    if (currentValue > rightValue)
                    {
                        values[decrement] = rightValue;
                        values[decrement + 1] = currentValue;
                    }
                    else
                    {
                        break;
                    }
                }

                Debug(values);
            }
        }

        static void Debug(int[] values)
        {
            Console.WriteLine("-------------------");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i].ToString() + " ");
            }
            Console.WriteLine("");
        }
    }
}
