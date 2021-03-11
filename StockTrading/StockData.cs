using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    public class StockData
    {
        public string StockName { get; set; }
        public double Value { get; set; }

        StockData(string stockName, double value)
        {
            Value = value;
            StockName = stockName;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {StockName} value {Value}");
        }
    }
}
