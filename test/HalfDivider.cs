using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace test
{
    public class HalfDivider
    {
        //private int[] array = { 1, 4, 7, 10 };
        //private int[] array = { 3,2,4,7,12};
        private int[] array = { 3, 2, 4, 7 };
        //private int[] array = { 2, 5, 7, 14, 18 };
        //private int[] array = { 33, 11, 22 };
        //private int[] array = { 56, 11, 22 };
        public HalfDivider()
        {
            string result = CanBeDevidedIntoTwo(array, new Stack<int>()) ? "Yes" : "No";

            Console.WriteLine($"The Collection can be devided into two: { result }");
        }

        private bool CanBeDevidedIntoTwo(int[] array, Stack<int> print, int sum = 0, int index = 0)
        {
            bool result = false;
            if (sum > array.Sum() - sum)
            {
                return false;
            }
            else if (sum == array.Sum() - sum)
            {
                PrintArray(print.ToList());
                return true;
            }
            else
            {
                for (int i = index; i < array.Length; i++)
                {
                    print.Push(array[i]);
                    result = result || CanBeDevidedIntoTwo(array, print, sum + array[i], index + 1);
                    print.Pop();
                }
                return result;
            }
        }

        private void PrintArray(List<int> list)
        {
            list.ForEach(x => { Console.Write(x + " "); });
            Console.Write("= ");
            array.Where(x => !list.Contains(x)).ToList().ForEach(x => { Console.Write(x + " "); });
            Console.WriteLine();
        }

    }
}

