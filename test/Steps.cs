using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Steps
    {
        public Steps()
        {
            int distance = 5;
            int[] validSteps = { 2, 3, 5 };
            int ways = DogToBone(distance, validSteps);
            Console.WriteLine($"number of ways: { ways}");
        }

        private int DogToBone(int distance, int[] validSteps)
        {
            return DoSteps(distance, validSteps, new List<int>());
        }

        private int DoSteps(int distance, int[] validSteps, List<int> print)
        {
            if (distance == 0)
            {
                PrintColl(print);
                return 1;
            }
            else if (distance < 0)
            {
                //print.RemoveAt(print.Count - 1);
                return 0;
            }
            int count = 0;
            for (int i = 0; i < validSteps.Length; i++)
            {
                int step = validSteps[i];
                print.Add(step);
                count += DoSteps(distance - step, validSteps, print);
                print.RemoveAt(print.Count - 1);
            }
            return count;
        }
        private static void PrintColl(List<int> print)
        {
            print.ForEach(x => { Console.Write(x + " "); });
            Console.WriteLine();
        }
    }
}
