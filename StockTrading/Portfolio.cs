using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    public class Portfolio : ISubject<Portfolio>, IObserver<PortfolioDisplay>
    {
        private List<IObserver<Portfolio>> observers = new List<IObserver<Portfolio>>();
        private List<Stock> stocks;

        public Portfolio()
        {
            stocks = new List<Stock>();
        }

        public void addStock(string name, double value)
        {
            Stock tempStock = new Stock(name,value);
            stocks.Add(tempStock);
        }

        public void Attach(IObserver<Portfolio> observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver<Portfolio> observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var display in observers)
            {
                display.Update(this);
            }
        }

        public void Update(PortfolioDisplay stockData)
        {
            
        }
    }
}
