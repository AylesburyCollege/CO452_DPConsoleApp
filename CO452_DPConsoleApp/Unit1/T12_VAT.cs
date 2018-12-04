﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_DPConsoleApp.Unit1
{
    /// <summary>
    /// This class calculates to amount of VAT on
    /// the price of an item
    /// 
    /// CO452 Unit 1: Task 1.2
    /// 02/12/2018 by Derek Peacock
    /// </summary>
    class T12_VAT
    {
        private static string input;  // Used to get input from the user
        private static decimal price; // The price of an item
        private static decimal vat;   // The amount of VAR
        private static decimal rate;  // The current VAT Rate
        private static string name;   // The name of the user

        public static void Calculate()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Derek's VAT Calculator   ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.Write("What is your name >");
            name = Console.ReadLine();

            Console.Write("Enter the price of your item " + name + " > ");
            input = Console.ReadLine();
            price = Convert.ToDecimal(input);

            Console.Write("Enter the VAT rate > " + name + " > ");
            input = Console.ReadLine();
            rate = Convert.ToDecimal(input);

            vat = rate * price / 100;

            Console.WriteLine();
            Console.WriteLine("VAT Amount = " + vat);
            Console.WriteLine("VAT Rate = " + rate);
        }

    }
}
