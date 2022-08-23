using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class AnagramDetection
    {
        public void anaGramDetection()
        {
            string str1 = "heart";
            string str2 = "earth";
            char[] chr1 = str1.ToCharArray();
            char[] chr2 = str2.ToCharArray();

            Array.Sort(chr1);
            Array.Sort(chr2);

            string val1 = new string(chr1);
            string val2 = new string(chr2);

            Console.WriteLine(val1);
            Console.WriteLine(val2);

            if (val1 = val2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("not Anagram");
            }
        }
    }
}
