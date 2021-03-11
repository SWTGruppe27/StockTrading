using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    public class Stock : ISubject<Stock>
    {
        private List<IObserver<Stock>> observers = new List<IObserver<Stock>>();

        public string StockName { get; private set; }
        public double Value { get;  set; }

        public Stock(string name, double value)
        {
            StockName = name;
            Value = value;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {StockName} Value: {Value}");
        }

        public void ChangeStockValue(double value)
        {
            Value = value;
            Notify();
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
