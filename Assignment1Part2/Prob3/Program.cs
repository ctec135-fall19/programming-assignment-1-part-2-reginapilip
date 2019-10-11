using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 REGION ONE:
    Create 3 nested loops, one for each condition. In the body of the inner-most loop
    print a line stating the conditions. For example:
        Conditions: prints: False, flashing light: False, printer recognized: False

    use if statements to call the appropriate methods to print out the possible actions.
    use vertical spacing as appropriate to make the output readable.

REGION TWO: 
    In a separate section of code implement a single for loop that iterates from 0 to 7. 
    The programmer's trick here is to represent the condition values as a number. Using 0 
    for No and 1 for Yes, the conditions can be converted to a binary number. Use Printer prints 
    as the most signicant bit, red light flashing as the next most significant, and so one. 
    If all conditions are Yes, you get a binary number, 111 which translates to 7. Each column 
    in the table above can be labeled with a number using this system.
    In the loop body implement a switch statement that uses the iteration variable as its value. 
    The code in each case will call the appropriate methods based on the number (column in the table).

 Note: Directions are also disbursed throughout the regions for clarification of what each region 
 is doing. 
 */
namespace Prob3
{
    class Program                               
    {
        static void Main(string[] args)
        {
            #region region 1
            Console.WriteLine("======================= REGION ONE =======================\n");
            // cond1 = printer prints
            for(int cond1 = 0; cond1 <=1; cond1++)
            {
                // cond2 = red light flashing
                for(int cond2 = 0; cond2 <=1; cond2++)
                {
                    for(int cond3 = 0; cond3 <=1; cond3++)
                    {
                        // Conditions all set to no: 0 0 0
                        if (cond1 == 0 && cond2 == 0 && cond3 == 0)
                        {
                            Console.WriteLine("*** PRINTER CONDITIONS ***");
                            Console.WriteLine("Printer Prints: NO\nRed Light Flashing: NO\nComputer Recognition: NO\n");
                            Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                            // Methods called as appropriate to the conditions set
                            CheckPowerCable();
                            CheckPrinterCompCable();
                            CheckSoftwareInstall();
                            Console.WriteLine("\n---------------------------------------------------------\n");
                        }

                        // Conditions set to no no yes: 0 0 1
                        if (cond1 == 0 && cond2 == 0 && cond3 == 1)
                        {
                            Console.WriteLine("*** PRINTER CONDITIONS ***");
                            Console.WriteLine("Printer Prints: NO\nRed Light Flashing: NO\nComputer Recognition: YES\n");
                            Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                            CheckPaperJam();
                            Console.WriteLine("\n---------------------------------------------------------\n");
                        }

                        // Conditions set to no yes no: 0 1 0
                        if (cond1 == 0 && cond2 == 1 && cond3 == 0)
                        {
                            Console.WriteLine("*** PRINTER CONDITIONS ***");
                            Console.WriteLine("Printer Prints: NO\nRed Light Flashing: YES\nComputer Recognition: NO\n");
                            Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                            CheckPrinterCompCable();
                            CheckSoftwareInstall();
                            CheckInk();
                            Console.WriteLine("\n---------------------------------------------------------\n");
                        }

                        // Conditions set to no yes yes: 0 1 1
                        if (cond1 == 0 && cond2 == 1 && cond3 == 1)
                        {
                            Console.WriteLine("*** PRINTER CONDITIONS ***");
                            Console.WriteLine("Printer Prints: NO\nRed Light Flashing: YES\nComputer Recognition: YES\n");
                            Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                            CheckInk();
                            CheckPaperJam();
                            Console.WriteLine("\n---------------------------------------------------------\n");
                        }

                        // Conditions set to yes no no: 1 0 0
                        if (cond1 == 1 && cond2 == 0 && cond3 == 0)
                        {
                            Console.WriteLine("*** PRINTER CONDITIONS ***");
                            Console.WriteLine("Printer Prints: YES\nRed Light Flashing: NO\nComputer Recognition: NO\n");
                            Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                            CheckSoftwareInstall();
                            Console.WriteLine("\n---------------------------------------------------------\n");
                        }

                        // Conditions set to yes no yes: 1 0 1
                        if (cond1 == 1 && cond2 == 0 && cond3 == 1)
                        {
                            Console.WriteLine("*** PRINTER CONDITIONS ***");
                            Console.WriteLine("Printer Prints: YES\nRed Light Flashing: NO\nComputer Recognition: YES\n");
                            Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                            Console.WriteLine("No Issues Found");
                            Console.WriteLine("\n---------------------------------------------------------\n");
                        }

                        // Conditions set to yes yes no: 1 1 0
                        if (cond1 == 1 && cond2 == 1 && cond3 == 0)
                        {
                            Console.WriteLine("*** PRINTER CONDITIONS ***");
                            Console.WriteLine("Printer Prints: YES\nRed Light Flashing: YES\nComputer Recognition: NO\n");
                            Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                            CheckSoftwareInstall();
                            Console.WriteLine("\n---------------------------------------------------------\n");
                        }

                        // Conditions set to yes yes yes: 1 1 1
                        if (cond1 == 1 && cond2 == 1 && cond3 == 1)
                        {
                            Console.WriteLine("*** PRINTER CONDITIONS ***");
                            Console.WriteLine("Printer Prints: YES\nRed Light Flashing: YES\nComputer Recognition: YES\n");
                            Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                            CheckInk();
                            Console.WriteLine("\n---------------------------------------------------------\n");
                        }
                    }
                }
            }
            #endregion



            #region region 2
            Console.WriteLine("\nTo continue to region 2, press <Enter>");
            Console.ReadLine();
            Console.WriteLine("======================= REGION TWO =======================\n");
            // create a loop that iterates 0-7 
            // use switch/case statements to call 
            // related methods to specific conditions
            // print condition status within each case
            for(int i = 0; i < 8; i++)
            {
                switch(i)
                {
                    // Conditions all set to no: 0 0 0
                    case 0:
                        Console.WriteLine("*** PRINTER CONDITIONS ***");
                        Console.WriteLine("Printer Prints: NO\nRed Light Flashing: NO\nComputer Recognition: NO\n");
                        Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                        CheckPowerCable();
                        CheckPrinterCompCable();
                        CheckSoftwareInstall();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 1:
                        // Conditions set to no no yes: 0 0 1
                        Console.WriteLine("*** PRINTER CONDITIONS ***");
                        Console.WriteLine("Printer Prints: NO\nRed Light Flashing: NO\nComputer Recognition: YES\n");
                        Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                        CheckPaperJam();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 2:
                        // Conditions set to no yes no: 0 1 0
                        Console.WriteLine("*** PRINTER CONDITIONS ***");
                        Console.WriteLine("Printer Prints: NO\nRed Light Flashing: YES\nComputer Recognition: NO\n");
                        Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                        CheckPrinterCompCable();
                        CheckSoftwareInstall();
                        CheckInk();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                            break;
                    case 3:
                        // Conditions set to no yes yes: 0 1 1
                        Console.WriteLine("*** PRINTER CONDITIONS ***");
                        Console.WriteLine("Printer Prints: NO\nRed Light Flashing: YES\nComputer Recognition: YES\n");
                        Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                        CheckInk();
                        CheckPaperJam();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 4:
                        // Conditions set to yes no no: 1 0 0
                        Console.WriteLine("*** PRINTER CONDITIONS ***");
                        Console.WriteLine("Printer Prints: YES\nRed Light Flashing: NO\nComputer Recognition: NO\n");
                        Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                        CheckSoftwareInstall();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 5:
                        // Conditions set to yes no yes: 1 0 1
                        Console.WriteLine("*** PRINTER CONDITIONS ***");
                        Console.WriteLine("Printer Prints: YES\nRed Light Flashing: NO\nComputer Recognition: YES\n");
                        Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                        Console.WriteLine("No Issues Found");
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 6:
                        // Conditions set to yes yes no: 1 1 0
                        Console.WriteLine("*** PRINTER CONDITIONS ***");
                        Console.WriteLine("Printer Prints: YES\nRed Light Flashing: YES\nComputer Recognition: NO\n");
                        Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                        CheckSoftwareInstall();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 7:
                        // Conditions set to yes yes yes: 1 1 1
                        Console.WriteLine("*** PRINTER CONDITIONS ***");
                        Console.WriteLine("Printer Prints: YES\nRed Light Flashing: YES\nComputer Recognition: YES\n");
                        Console.WriteLine("*** TROUBLESHOOTING OPTIONS ***");
                        CheckInk();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                }
            }
            #endregion
        }



        #region methods
        /*
         Create methods for each of the actions (see diagram)
         Each method should contain a print statement with the text
         from the Actions part of the table as the output:
         - Check power cable            - Check the printer-computer cable
         - Ensure printer software      - Check/replace ink
            is installed                - Check for paper jam
         */
         // Action 1: power cable
        static void CheckPowerCable()
        {
            Console.WriteLine("Check the Power Cable");
        }

        // Action 2: printer-computer cable
        static void CheckPrinterCompCable()
        {
            Console.WriteLine("Check the Printer-Computer Cable");
        }

        // Action 3: printer software
        static void CheckSoftwareInstall()
        {
            Console.WriteLine("Ensure Printer Software is Installed");
        }

        // Action 4: Ink
        static void CheckInk()
        {
            Console.WriteLine("Check Ink Status and Replace if Necessary");
        }

        // Action 5: Paper Jam
        static void CheckPaperJam()
        {
            Console.WriteLine("Check for a Paper Jam");
        }
        #endregion
    }
}
