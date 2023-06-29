using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3
{
    public class Finding
    {
        private string findCustomer;
        public List<Customer> findingCustomers = new List<Customer>();
        public Finding(string findCustomer)
        {
            Name = findCustomer;
        }
        public Finding() { }

        public string Name { get => findCustomer; set => findCustomer = value; }
       

        public void FindCustomer(Customer c)
        {
            if (findingCustomers.Contains(c))
            {
                throw new Exception("Customer does not exist");
            }
            else
            {
                findingCustomers.Add(c);
            }
        }
        public int NumCustomer()
        {
            return findingCustomers.Count;
        }
        public bool findaCustomer(Customer c)
        {
            if (findingCustomers.Contains(c))
            { return true; }
            else
            { return false; }
        }
    }
}


