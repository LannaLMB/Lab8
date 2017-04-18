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
            Console.WriteLine("Welcome To The Batting Average Calculator!");
            Console.WriteLine();


            // User Input for Array Length
            Console.WriteLine("Please Enter the Number of Times at Bat: ");
            int size = int.Parse(Console.ReadLine());


            // Declare Variables
            int[] AtBat = new int[size];
            double SlugPerc;
            double BatAve;
            string Continue;

            // Key/Legend
            Console.WriteLine("0 = Out 1 = Single 2 = Double 3 = Triple 4 = Homerun");
            Console.WriteLine();


            while (true)
            {
                for (int i = 0; i <= size - 1; i++)
                {
                    Console.WriteLine($"Result of at bats {i}:");
                    AtBat[i] = int.Parse(Console.ReadLine());
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
                SlugPerc = (double)sum / (double)size;
                //Console.WriteLine("The Slugging Percentage is: " + SlugPerc);
                Console.WriteLine("The Slugging Percentage is: " + SlugPerc.ToString("#,#.000"));

                BatAve = ((double)count / (double)size);
                //Console.WriteLine("The Batting Average is: " + BatAve);
                Console.WriteLine("The Batting Average is: " + BatAve.ToString("#,#0.000"));




                //Continue Loop
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Another Batter?  (y/n)");
                    Continue = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    if (Continue == "Y")
                        break;

                    if (Continue == "N")
                        return;

                    else
                        Console.WriteLine("Please Enter Y or N");
                }
            }
        }
    }
}
