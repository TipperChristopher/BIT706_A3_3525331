using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public interface IObserver
    {
        void Update(Customer c);
    }

    public interface IAccounts
    {
        void AttachObserver(IObserver obs);
        void NotifyObservers(Customer c);
    }

    public interface IIterator
    {
        object getNext();
        bool isDone();
    }
}
