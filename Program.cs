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
            StockAppCalculator transaction = new StockAppCalculator();
            string inputValue;
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
            WriteLine(transaction.StockName);
            // inputValue = ReadLine();
            // transaction.StockName.set(inputValue);
            Write("Enter shares bought: ");
            WriteLine(transaction.StockSharesBought);
            // inputValue = ReadLine();
            // transaction.SharesBought.set(double.Parse(inputValue));
            Write("Enter price bought: ");
            WriteLine(transaction.StockPriceBought);
            // inputValue = ReadLine();
            // transaction.PriceBought.set(double.Parse(inputValue));
            Write("Enter price sold: ");
            WriteLine(transaction.StockPriceSold);
            // inputValue = ReadLine();
            // transaction.PriceSold.set(double.Parse(inputValue));
            WriteLine("*******************************");
            Write("        ");
            WriteLine(transaction.StockName);
            Write("Bought price     ");
            WriteLine("{0:C}", transaction.Buy());
            Write("Sold price       ");
            WriteLine("{0:C}", transaction.Sell());
            Write("Difference       ");
            WriteLine("{0:C}", transaction.Difference());
            ReadLine();
        }
    }
}