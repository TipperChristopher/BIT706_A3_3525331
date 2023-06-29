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
    public partial class MainMenu : Form
    {
        Library library;
        Customer c;
        CustomersMenu m;

        public MainMenu(Library lib)
        {
            InitializeComponent();
            library = lib;
            
        }
  
        public void ClickCustomerButton()
        {
          btnCustomers.PerformClick();
        }

        public void ClickAccountsButton()
        {
          btnAccounts.PerformClick();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ClickCustomerButton();
            library.Equals(btnCustomers);
            CustomersMenu menu = new CustomersMenu();
            menu.Show();
            menu.MdiParent = this;
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            ClickAccountsButton();
            library.Equals(btnAccounts);
            ManageAccounts manageAccounts = new ManageAccounts();
            manageAccounts.Show();
            manageAccounts.MdiParent = this;
        }
    }
}
