using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace test
{
    public class HalfDivider
    {
        public HalfDivider()
        {
            //int[] array = { 1, 4, 7, 10 }; //yes
            //int[] array = { 3, 2, 4, 7, 12 }; //yes
            //int[] array = { 3, 2, 4, 7 };// L no
            //int[] array = { 3, 2, 4, 7, 12 };// L yes
            //int[] array = { 2, 5, 7, 14, 18 }; // yes
            //int[] array = { 33, 11, 22 }; //yes
            // int[] array = { 56, 11, 22 }; //no
            int[] array = { 11, 11, 22 ,33}; //no
            string result = CanBeDevidedIntoTwo(array, array, new Stack<int>()) ? "Yes" : "No";

            Console.WriteLine($"The Collection can be devided into two: { result }");
        }

        private bool CanBeDevidedIntoTwo(int[] array, int[] originArray, Stack<int> print, int sum = 0)
        {
            bool result = false;
            if (sum > originArray.Sum() - sum)
            {
                return false;
            }
            else if (sum == originArray.Sum() - sum)
            {
                PrintArray(print.ToList(), originArray);
                return true;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    print.Push(array[i]);
                    result = result || CanBeDevidedIntoTwo(array.Skip(i + 1).ToArray(), originArray, print, sum + array[i]);
                    print.Pop();
                }
                return result;
            }
        }

        private void PrintArray(List<int> list, int[] originArray)
        {
            list.ForEach(x => { Console.Write(x + " "); });
            Console.Write("= ");
            originArray.Where(x => !list.Contains(x)).ToList().ForEach(x => { Console.Write(x + " "); });
            Console.WriteLine();
        }

    }
    public static class ExtensionMethods
    {
        public static bool IsHalf(this int sum, int[] array)
        {
            return sum == array.Sum() - sum;
        }
        public static bool Bigger(this int sum, int[] array)
        {
            return sum > array.Sum() - sum;
        }
    }
}

