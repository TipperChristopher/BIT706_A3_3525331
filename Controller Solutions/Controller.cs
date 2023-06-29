using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Assessment3;

/// <summary>
///  
/// </summary>
class Controller
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        public List<Customer> AllCustomers = new List<Customer>();

        Adding a = new Adding();
        Finding f = new Finding();
        Editing e = new Editing();
        Deleting d = new Deleting();
        Controller control = new Controller();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ID"></param>
        public void AddCustomer(string name, int ID)
        {
            AllCustomers.Add(new AddingCustomer (name, ID));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Customer AddCustomerByID(int ID)
        {
            var pubs = from a in AllCustomers
                       where a.ID == ID
                       select a;

            foreach (Customer c in AllCustomers)
            {
                if (c.ID == ID) { return c; }
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool AddCustomer(int ID, Adding a)
        {
            try
            {
                a.AddCustomer(FindCustomerByID(ID));
                return true;
            }
            catch (Exception b)
            {
                errorMessage = b.Message;
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ID"></param>
        public void FindCustomer(string name, int ID)
        {
            AllCustomers.BinarySearch(new FindingCustomer(name, ID));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Customer FindCustomerByID(int ID)
        {
            var pubs = from f in AllCustomers
                       where f.ID == ID
                       select f;

            foreach (Customer c in AllCustomers)
            {
                if (c.ID == ID) { return c; }
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool FindCustomer(int ID, Finding f)
        {
            try
            {
                f.FindCustomer(FindCustomerByID(ID));
                return true;
            }
            catch (Exception b)
            {
                errorMessage = b.Message;
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ID"></param>
        public void EditCustomer(string name, int ID)
        {
            AllCustomers.Remove(new EditingCustomer(name, ID));
        }
        public Customer EditCustomerByID(int ID)
        {
            var pubs = from e in AllCustomers
                       where e.ID == ID
                       select e;

            foreach (Customer c in AllCustomers)
            {
                if (c.ID == ID) { return c; }
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool EditCustomer(int ID, Editing e)
        {
            try
            {
                e.EditCustomer(EditCustomerByID(ID));
                return true;
            }
            catch (Exception b)
            {
                errorMessage = b.Message;
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ID"></param>
        public void DeleteCustomer(string name, int ID)
        {
            AllCustomers.Remove(new DeletingCustomer(name, ID));
        }

        public Customer DeleteCustomerByID(int ID)
        {
            var pubs = from d in AllCustomers
                       where d.ID == ID
                       select d;

            foreach (Customer c in AllCustomers)
            {
                if (c.ID == ID) { return c; }
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public bool DeleteCustomer(int ID, Deleting d)
        {
            try
            {
                d.DeleteCustomer(DeleteCustomerByID(ID));
                return true;
            }
            catch (Exception b)
            {
                errorMessage = b.Message;
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private string errorMessage;
        public string ErrorMessage { get => errorMessage; }
    }
    
}

