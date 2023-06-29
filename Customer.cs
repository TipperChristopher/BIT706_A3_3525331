using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assessment3
{
    public abstract class Customer
    {
        private string customer;
        private static int customerID = 1;
        private int iD;

        public string Customers { get => customer; set => customer = value; }
        public int ID { get => iD; set => iD = value; }

        public Customer() 
        {
            ID = customerID;
            customerID++;
            Customers = "Customer: " + ID;
        }

        public Customer(string newCustomer) : this()
        {
            Customers = newCustomer;
        }
        public virtual string Info()
        {
            return ID + " " + Customers;
        }
        public override string ToString()
        {
            return Info();
        }
    }

    public class AddingCustomer : Customer
    {
        public AddingCustomer()
        {
        }

        public AddingCustomer(string newCustomer) : base(newCustomer) { }
        public AddingCustomer(string newCustomer, int newID) : this(newCustomer)
        {
            NumID = newID;
        }
        private int NumID { get => NumID; set => NumID = value; }
        public override string Info()
        {
            return base.Info() + " " + NumID + " Add Customer ";

        }
    }

    public class FindingCustomer : Customer
    {

        public FindingCustomer(string findCustomer) : base(findCustomer) { }
        public FindingCustomer(string findCustomer, int findID) : this(findCustomer)
        {
            NumID = findID;
        }
        private int NumID { get => NumID; set => NumID = value; }
        public override string Info()
        {
            return base.Info() + " " + NumID + " Find Customer ";

        }
    }

    public class EditingCustomer : Customer
    {
        public EditingCustomer(string editCustomer) : base(editCustomer) { }
        public EditingCustomer(string editCustomer, int editID) : this(editCustomer)
        {
            NumID = editID;
        }
        private int NumID { get => NumID; set => NumID = value; }
        public override string Info()
        {
            return base.Info() + " " + NumID + " Edit Customer";

        }
    }

    public class DeletingCustomer : Customer
    {

        public DeletingCustomer(string deleteCustomer) : base(deleteCustomer) { }
        public DeletingCustomer(string deleteCustomer, int deleteID) : this(deleteCustomer)
        {
            NumID = deleteID;
        }
        private int NumID { get => NumID; set => NumID = value; }
        public override string Info()
        {
            return base.Info() + " " + NumID + " Delete Customer ";

        }
    }


}
