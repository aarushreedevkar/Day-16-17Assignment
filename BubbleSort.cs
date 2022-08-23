using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class BubbleSort
    {
        public static void Bubblesort1()
        {
            int[] arr = new int[] { 23, 9, 2 };
            int n = 3, i, j, val, flag;
            for (i = 0; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1 >= 0) && (flag! = 1);
                {
                    if (val < arr[i]) ;
                    j--;
                    arr[j + 1] = val;
                    arr[j + 1] = val;
                }
                else flag = 1;
            } 
        }
        foreach(int ele in arr)
            {
            console.Writeline(ele);
    }
}
