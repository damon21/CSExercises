using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            int i = 0;
            while( i + s2.Length < s1.Length)
            {
                string A = s1.Substring(i, s2.Length);
                if (A.CompareTo(s2) == 0)
                {
                    return i;
                }

                i++;
            }


            return -1;
        }
    }
}
