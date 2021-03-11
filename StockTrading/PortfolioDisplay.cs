using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    public class PortfolioDisplay : IObserver<Portfolio>
    {
        private ISubject<Portfolio> _portfolieSubject;

        public PortfolioDisplay(ISubject<Portfolio> subject)
        {
            _portfolieSubject = subject;
            _portfolieSubject.Attach(this);
        }
        public void Update(Portfolio portfolio)
        {
            Console.WriteLine("Updated List of stocks in portfolio\n");
            foreach (var stock in portfolio.stocksInPortfolio)
            {
                stock.Print();
            }
        }
    }
}
