using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockTrading
{
    public class Portfolio : ISubject<Portfolio>, IObserver<Stock>
    {
        private List<IObserver<Portfolio>> observers = new List<IObserver<Portfolio>>();
        public ISubject<Stock> StockSubject { get; private set; }
        public List<Stock> stocksInPortfolio { get; private set; }

        public Portfolio(ISubject<Stock> subject)
        {
            StockSubject = subject;
            StockSubject.Attach(this);
            stocksInPortfolio = new List<Stock>();
        }


        public void AddStockToPortfolio(Stock addStock)
        {
            stocksInPortfolio.Add(addStock);
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

        public void Update(Stock updateStock)
        {
            int itemIndex = stocksInPortfolio.FindIndex(x => x.StockName == updateStock.StockName);
            Stock itemWhoNeedUpdate = stocksInPortfolio.ElementAt(itemIndex);
            itemWhoNeedUpdate.Value = updateStock.Value;

            Notify();
        }
    }
}
