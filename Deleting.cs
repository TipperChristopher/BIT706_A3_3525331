using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3
{
    public class Deleting
    {
        private string deleteCustomer;
        public List<Customer> deletingCustomers = new List<Customer>();
        public Deleting(string findCustomer)
        {
            Name = findCustomer;
        }
        public Deleting() { }

        public string Name { get => deleteCustomer; set => deleteCustomer = value; }

        public void DeleteCustomer(Customer c)
        {
            
         if (deletingCustomers.Contains(c))
         {
              MessageBox.Show("This customer does not exists");
         }
         else
         {
                deletingCustomers.Remove(c);
         } 
        }
        public int NumCustomers()
        {
            return deletingCustomers.Count;
        }
        public bool deleteaCustomer(Customer c)
        {
            if (deletingCustomers.Contains(c))
            { return true; }
            else
            { return false; }
        }
    }
}

