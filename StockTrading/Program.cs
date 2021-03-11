using System;

namespace StockTrading
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock1 = new Stock("Vestas", 1053.16);
            Stock stock2 = new Stock("Danske Bank", 94.84);

            Portfolio portfolio = new Portfolio(stock1);

            PortfolioDisplay display = new PortfolioDisplay(portfolio);

            stock1.Print();
            portfolio.AddStockToPortfolio(stock1);
            portfolio.AddStockToPortfolio(stock2);

            stock2.ChangeStockValue(8325.3);
        }
    }
}
