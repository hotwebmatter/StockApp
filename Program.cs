/**
 * ######################################################
 * ##    Programming Assignment #6                     ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: October 06 2019               ##
 * ##    Purpose: Demonstrate usage of OOP concepts.   ##
 * ######################################################
 */
using System;
using static System.Console;

namespace StockApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            string name;
            double sharesBought;
            double priceBought;
            double priceSold;
            WriteLine("*******************************************************");
            WriteLine("        Stock Transactions");
            WriteLine("        Calculate results of stock bought and sold");
            WriteLine("        Matthew Obert");
            WriteLine("        October 06, 2019");
            WriteLine("*******************************************************");
            WriteLine("This program will determine profit or loss on stock.\n");
            WriteLine("You will be asked to enter the stock name, number of shares,");
            WriteLine(" price bought, and price sold.\n");
            WriteLine("*******************************************************");
            WriteLine("*******************************");
            Write("Enter stock name: ");
            name = ReadLine();
            Write("Enter shares bought: ");
            inputValue = ReadLine();
            sharesBought = double.Parse(inputValue);
            Write("Enter price bought: ");
            inputValue = ReadLine();
            priceBought = double.Parse(inputValue);
            Write("Enter price sold: ");
            inputValue = ReadLine();
            priceSold = double.Parse(inputValue);

            // instantiate transaction object by calling StockAppCalculator constructor method
            StockAppCalculator transaction = new StockAppCalculator(name, sharesBought, priceBought, priceSold);

            // output the results of our method calculations
            WriteLine("*******************************");
            Write("        ");
            WriteLine(transaction.StockName);
            Write("Bought price     ");
            WriteLine("{0:C}", transaction.Buy());
            Write("Sold price       ");
            WriteLine("{0:C}", transaction.Sell());
            Write("Difference       ");
            WriteLine("{0:C}", transaction.Difference());
        }
    }
}