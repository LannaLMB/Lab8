/*  Author:  Lanna Brasure
 *  Date:  418/17
 *  Program:  Lab 8 - Batting Average Calculator
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            // Welcome Message
            Console.WriteLine("\nWelcome To The Batting Average Calculator!");
            Console.WriteLine();


            // Declare Variables
            double SlugPerc;
            double BatAve;
            string Continue;


            // Continue to Add Another Batter
            while (true)
            {

                // User Input for Array Length
                Console.WriteLine("------------------------------------------------");
                Console.Write("Please Enter the Number of Times At-Bat:  --->   ");
                int size = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                int[] AtBat = new int[size];



                // Key/Legend
                Console.WriteLine("******************  Legend / Key ***********************");
                Console.WriteLine("0 = Out  1 = Single  2 = Double  3 = Triple  4 = Homerun");
                Console.WriteLine("\n");



                // Getting User Input for AtBat
                for (int i = 0; i <= size - 1; i++)
                {


                    Console.Write($"Result of At-Bats {i}:  --->   ");
                    AtBat[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    {
                        if (AtBat[i] > 4)
                        {
                            Console.WriteLine("The Result Entered MUST Be 0, 1, 2, 3, OR 4.");
                            return;
                        }   
                    }
                }




                // Get Average
                double sum = 0.0;
                int count = 0;
                for (int i = 0; i <= size - 1; i++)
                {
                    sum = sum + AtBat[i];
                    if (AtBat[i] != 0)
                    {
                        count++;
                    }
                }



                // Get Slugging Perentage
                SlugPerc = ((double)sum / (double)size);
                Console.WriteLine();
                Console.WriteLine("The Slugging Percentage is: " + SlugPerc.ToString("#,#.000"));  // Convert Slugging Percentage to a string to get formatted with 3 decimal places


                //Get Batting Average
                BatAve = ((double)count / (double)size);
                Console.WriteLine("The Batting Average is: " + BatAve.ToString("#,#0.000"));  // Convert Batting Average to a string to get formatted with 3 decimal places




                //Continue Loop
                while (true)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Another Batter?  (y/n)");
                    Continue = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    if (Continue == "Y")
                        break;

                    if (Continue == "N")
                        return;

                    else
                        Console.ForegroundColor = ConsoleColor.Red;  // Red to Alert User Input is Invalid
                        Console.WriteLine("Please Enter Y or N");
                        Console.ForegroundColor = ConsoleColor.Green;   // Green to Go Back to Original Color
                }
            }
        }
    }
}
