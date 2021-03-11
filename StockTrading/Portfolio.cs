using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    public class Portfolio : ISubject<Portfolio>, IObserver<PortfolioDisplay>
    {
        private List<IObserver<Portfolio>> observers = new List<IObserver<Portfolio>>();

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

        }

        public void Update(Portfolio stockData)
        {

        }
    }
}
