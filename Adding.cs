using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3
{
    public partial class Adding
    {
        private string addCustomer;
        public List<Customer> addingCustomers = new List<Customer>();
        Library library;

        public Adding(Library lib)
        {
            
            library = lib;
        }


        public Adding(string addCustomer)
        {
            Name = addCustomer;
        }

        public Adding()
        {
        }

        public string Name { get => addCustomer; set => addCustomer = value; }

        public void AddCustomer(Customer c)
        {
            if (addingCustomers.Contains(c))
            {
                throw new Exception("Customer already exists");
            }
            else
            {
                addingCustomers.Add(c);
            }
        }

        public int NumCustomers()
        {
            return addingCustomers.Count;
        }
        public bool addaCustomer(Customer c)
        {
            if (addingCustomers.Contains(c))
            { return true; }
            else
            { return false; }
        }
    }
}
