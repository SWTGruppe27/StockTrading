using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    public interface IObserver<T>
    {
        void Update(T stock);
    }
}
