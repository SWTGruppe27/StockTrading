using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    public interface ISubject<T> where T : class
    {
        void Attach(T observer);
        void Detach(T observer);
        void Notify();
    }
}
