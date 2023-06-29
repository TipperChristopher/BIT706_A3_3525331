using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assessment3
{
    public partial class CustomersMenu : Form
    {
        public static CustomersMenu instance;
        private List<Customer> AllCustomers = new List<Customer>();
        private Dictionary<int, Customer> CustomerByID = new Dictionary<int, Customer>();


        Controller control = new Controller();
        Adding a = new Adding();
        Editing g = new Editing();
        Finding f = new Finding();
        Deleting d = new Deleting();

        public CustomersMenu()
        {
            InitializeComponent();
            ReadTextFile();
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            listBox1.Width = 250;
            listBox1.Height = 50;
            listBox1.BackColor = Color.Blue;
            listBox1.ForeColor = Color.White;
            listBox1.BorderStyle = BorderStyle.Fixed3D;
            listBox1.Items.Add("Adding a Customer: ");
            listBox1.Items.Add("Editing a Customer: ");
            listBox1.Items.Contains("Finding a Customer: ");
            listBox1.Items.Remove("Deleting a Customer: ");
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        public void AddingCustomers()
        {
            foreach (Customer c in AllCustomers)
            {
                CustomerByID.Add(c.ID,c);
            }

            Customer customer = CustomerByID[100];
            MessageBox.Show(customer.Info());
        }

        public void FindingCustomers()
        {
            foreach (Customer c in AllCustomers)
            {
                CustomerByID.Add(c.ID, c);
            }

            Customer customer = CustomerByID[100];
            MessageBox.Show(customer.Info());
        }

        public void EditingCustomers()
        {
            foreach (Customer c in AllCustomers)
            {
                CustomerByID.Clear();
            }

            Customer customer = CustomerByID[100];
            MessageBox.Show(customer.Info());
        }

        public void DeletingCustomers()
        {
            foreach (Customer c in AllCustomers)
            {
                CustomerByID.Remove(c.ID);
            }

            Customer customer = CustomerByID[100];
            MessageBox.Show(customer.Info());
        }

        private void btnAdding_Click(object sender, EventArgs e)
        {
            Customer c = AllCustomers[listBox1.SelectedIndex];
            a.AddCustomer(c);
            AddingCustomers();
        }
        private void btnFinding_Click(object sender, EventArgs e)
        {
            Customer c = AllCustomers[listBox1.SelectedIndex];
            f.FindCustomer(c);
            FindingCustomers();
        }
        private void btnEditing_Click(object sender, EventArgs e)
        {
            Customer c = AllCustomers[listBox1.SelectedIndex];
            g.EditCustomer(c);
            EditingCustomers();
        }
        private void btnDeleting_Click(object sender, EventArgs e)
        {
            Customer c = AllCustomers[listBox1.SelectedIndex];
            d.DeleteCustomer(c);
            DeletingCustomers();
        }

        public void ReadTextFile()
        {
            Customer c = null;
            string[] strArray;

            //open file
            var myfile = new StreamReader("../../data.txt");

            while (!myfile.EndOfStream)
            {
                strArray = myfile.ReadLine().Split(',');

                if (strArray[0] == "Add Customer") { c = new AddingCustomer(strArray[1], Convert.ToInt32(strArray[2])); }
                if (strArray[0] == "Find Customer") { c = new EditingCustomer(strArray[1], Convert.ToInt32(strArray[2])); }
                if (strArray[0] == "Edit Customer") { c = new FindingCustomer(strArray[1], Convert.ToInt32(strArray[2])); }
                if (strArray[0] == "Delete Customer") { c = new DeletingCustomer(strArray[1], Convert.ToInt32(strArray[2])); }

                if (c != null)
                {

                    AllCustomers.Add(c);
                }
                else
                {
                    AllCustomers = null;
                }

            }
            myfile.Close();
        }

    }
}
