using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    public class Stock : ISubject<Stock>
    {
        private StockData stockData;
        private List<IObserver<Stock>> observers = new List<IObserver<Stock>>();

        public Stock(string name, double value)
        {
            stockData = new StockData(name, value);
        }

        public Stock()
        {
        }

        public void Attach(IObserver<Stock> observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver<Stock> observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver<Stock> observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
