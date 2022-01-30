using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace test
{
    public class Permutation
    {
        public Permutation()
        {
            string str = "ab";
            RunPermutation(str, string.Empty, str.Length);
        }
        private void RunPermutation(string str, string newStr, int max)
        {
            if (newStr.Length > max)
            {
                return;
            }
            else if (newStr.Length == max)
            {
                Console.WriteLine(newStr);
                return;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    RunPermutation(str.Remove(i, 1), newStr + str[i], max);
                }
            }
        }
    }
}
