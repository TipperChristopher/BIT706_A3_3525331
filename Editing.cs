using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3
{
    public class Editing
    {
        private string editCustomer;
        public List<Customer> editingCustomers = new List<Customer>();
        public Editing(string editCustomer)
        {
            Name = editCustomer;
        }
        public Editing() { }

        public string Name { get => editCustomer; set => editCustomer = value; }
        public static string Text { get; internal set; }

        public void EditCustomer(Customer c)
        {
            if (editingCustomers.Contains(c))
            {
                MessageBox.Show("This customer already exists");
            }
            else
            {
                editingCustomers.Remove(c);
            }
        }
        public int NumCustomers()
        {
            return editingCustomers.Count;
        }
        public bool editaCustomer(Customer c)
        {
            if (editingCustomers.Contains(c))
            { return true; }
            else
            { return false; }
        }
    }
}

