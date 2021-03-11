using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    public interface ISubject<T>
    {
        void Attach(IObserver<T> observer);
        void Detach(IObserver<T> observer);
        void Notify();
    }
}
