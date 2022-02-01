using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Groups
    {
        public Groups()
        {
            string text = "abcd";
            GetGroupsRecurcivery(text, 2, string.Empty);
        }
        private void GetGroupsRecurcivery(string text, int groupLength, string group)
        {
            if (group.Length == groupLength)
            {
                Console.Write(group + " ");
                return;
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    GetGroupsRecurcivery(text.Substring(i + 1), groupLength, group + text[i]);
                }
            }
        }
    }
}
