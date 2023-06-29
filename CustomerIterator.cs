using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class CustomerIterator : IIterator
    {
        private Library lib;
        private int customerID;
        public CustomerIterator(Library library) 
        {
            lib = library;
            customerID = 0;
        }

        public object getNext()
        {
            if (!isDone()) { return lib.myCustomers[customerID++]; }
            return null;
        }

        public bool isDone()
        {
            if (customerID < lib.myCustomers.Count) { return false; }
            return true;
        }
    }
}
