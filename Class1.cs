using System;
using System.Collections.Generic;
using System.Text;

namespace StockApp
{
    public class StockAppCalculator
    {
        private string stockName;
        private double stockSharesBought;
        private double stockPriceBought;
        private double stockPriceSold;
        private const double COMMISSION = 0.03;
        private double boughtPrice;
        private double soldPrice;
        private double difference;

        // Default constructor for "Example, Inc." stock transaction
        public StockAppCalculator()
        {
            stockName = "XMPL";
            stockSharesBought = 200;
            stockPriceBought = 25;
            stockPriceSold = 30;
        }

        // Constructor with all data members passed as arguments to parameters
        public StockAppCalculator(string name, double sharesBought, double priceBought, double priceSold)
        {
            stockName = name;
            stockSharesBought = sharesBought;
            stockPriceBought = priceBought;
            stockPriceSold = priceSold;
        }

        //Properties
        public string StockName
        {
            get
            {
                return stockName;
            }
            set
            {
                stockName = value;
            }
        }
        public double StockSharesBought
        {
            get
            {
                return stockSharesBought;
            }
            set
            {
                stockSharesBought = value;
            }
        }

        public double StockPriceBought
        {
            get
            {
                return stockPriceBought;
            }
            set
            {
                stockPriceBought = value;
            }
        }

        public double StockPriceSold
        {
            get
            {
                return stockPriceSold;
            }
            set
            {
                stockPriceSold = value;
            }
        }
        public double Buy()
        {
            boughtPrice = stockSharesBought * stockPriceBought * (1 + COMMISSION);
            return boughtPrice;
        }
        public double Sell()
        {
            soldPrice = stockSharesBought * stockPriceSold * (1 - COMMISSION);
            return soldPrice;
        }
        public double Difference()
        {
            difference = soldPrice - boughtPrice;
            return difference;
        }
    }
}
