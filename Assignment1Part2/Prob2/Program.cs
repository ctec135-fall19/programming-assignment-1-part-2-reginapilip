using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 For this problem print out the numbers 1-5 using several different loop structures.

print 1-5 with spaces between the numbers on a single line using a for loop
print 1-5 with spaces between the numbers on a single line using a while loop
print 1-5 with spaces between the numbers on a single line using a do/while loop

HINT: use Write() instead of WriteLine() in the loop body. Follow the loop with a WriteLine() 
call to insert the newline character at the end of the sequence.
 */
namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for loop
            Console.WriteLine("FOR LOOP");
            Console.WriteLine("------------");
            // print 1-5 with spaces between the numbers on a 
            // single line using a for loop.
            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            #endregion


            #region user input
            // waits for user input to continue
            Console.WriteLine("*** Press Enter to Proceed ***");
            Console.ReadLine();
            #endregion


            #region while loop
            Console.WriteLine("WHILE LOOP");
            Console.WriteLine("------------");
            // print 1-5 with spaces between the numbers on a
            // single line using a while loop
            int a = 1;
            while(a<=5)
            {
                Console.Write(a + " ");
                a++;
            }
            Console.WriteLine("\n");
            #endregion


            #region user input
            // waits for user input to continue
            Console.WriteLine("*** Press Enter to Proceed ***");
            Console.ReadLine();
            #endregion

            #region do/while loop
            Console.WriteLine("DO/WHILE LOOP");
            Console.WriteLine("------------");
            // print 1-5 with spaces between the numbers on a 
            // single line using a do/while loop
            int b = 1;
            do
            {
                Console.Write(b + " ");
                b++;
            }
            while (b <= 5);
            Console.WriteLine("\n");
            #endregion

            Console.WriteLine("*** End of Loops Program ***\n");

        }
    }
}
