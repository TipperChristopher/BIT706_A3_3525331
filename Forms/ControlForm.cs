using Assessment3;
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
    public partial class frmControl : Form
    {
        public Library lib = new Library();
        public frmControl()
        {
            InitializeComponent();

            MainMenu mainMenu = new MainMenu(lib);
            CustomersMenu customersMenu = new CustomersMenu();
            ManageAccounts manageAccounts = new ManageAccounts();

            lib.AttachObserver((IObserver)customersMenu);
            lib.AttachObserver((IObserver)manageAccounts);



            //code to show forms in the parent form
            mainMenu.MdiParent = this;
            customersMenu.MdiParent = this;
            manageAccounts.MdiParent = this;


            mainMenu.Show();
            customersMenu.Show();
            manageAccounts.Show();

            customersMenu.StartPosition = FormStartPosition.Manual;
            manageAccounts.StartPosition = FormStartPosition.Manual;
            manageAccounts.Location = new Point(250, 0);
            customersMenu.Location = new Point(500, 0);
        }
    }
}
