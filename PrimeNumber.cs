using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    
    public class PrimeNumber { 
    
    public void PrimeNumber1()
    {
        int num1, num2, flag_var, i, j;

        /* Ask user to input the from/to range
         * like 1 to 100, 10 to 1000 etc.
         */
        Console.WriteLine("Enter two range(input integer numbers only):");
        //Store the range in variables using scanf
       // Console.WriteLine(num1, num2);

        //Display prime numbers for input range
        Console.WriteLine("Prime numbers from 0 t0 1000 : num1, num2);
        for (i = num1 + 1; i < num2; ++i)
        {
            flag_var = 0;
            for (j = 2; j <= i / 2; ++j)
            {
                if (i % j == 0)
                {
                    flag_var = 1;
                    break;
                }
            }
            if (flag_var == 0)
            {
                return 0;
            }
        }
    }
}
