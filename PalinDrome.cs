using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class PalinDrome
    {
        public void PalinDrome1()
        {
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.ToInt32(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
            if num == reverse:
            if (num > 1)
            for i in  range(2, num):
            if (num % i == 0)
                console.writeline(num, "is not a prime number, but is a palindrome number!")
                break;
            else { 
            Console.writeline("This is a prime as well as a palindrome number!")
            else { 
            if( num > 1)
            for i in  range(2, num):
            if( num % i == 0)
                Console.Writeline(num, " This is not a prime nor a palindrome number.")
                break;
        else {
                        Console.WriteLine("This is a prime number but not a palindrome number!")
              }

        }
    }
}
