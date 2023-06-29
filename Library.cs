using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class Library
    {
        public List<Customer> myCustomers = new List<Customer>();
        public List<Accounts> myAccounts = new List<Accounts>();
        public List<IObserver> MyObservers = new List<IObserver>();

        public void AddCustomer()
        {
            Customer c = new AddingCustomer();
            myCustomers.Add(c);
            NotifyCustomers(c);
        }

        public void AttachObserver(IObserver obs)
        {
            MyObservers.Add(obs);
        }

        public void NotifyCustomers(Customer c)
        {
            foreach (IObserver obs in MyObservers)
            {
                obs.Update(c);
            }
        }

        public void AddAccount()
        {
            Accounts a = new Accounts();
            myAccounts.Add(a);
            NotifyAccounts(a);  
        }

      public void RemoveAccount() 
        { 
            Accounts a = new Accounts();
            myAccounts.Remove(a);
            NotifyAccounts(a);
        }


        public void NotifyAccounts(Accounts a)
        {
            foreach (IObserver obs in MyObservers)
            {
               
            }
        }


        public IIterator CreateIterator()
        {
            return new CustomerIterator(this);
        }
    }
}

