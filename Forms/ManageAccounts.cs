using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3
{
    public partial class ManageAccounts : Form
    {
        private List<Accounts> AllAccounts = new List<Accounts>();
        private Dictionary<int, Accounts> AccountByID = new Dictionary<int, Accounts>();
        Controller control = new Controller();
        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            textBox1.Width = 250;
            textBox1.Height = 50;
            textBox1.Multiline = true;
            textBox1.BackColor = Color.Blue;
            textBox1.ForeColor = Color.White;
            textBox1.BorderStyle = BorderStyle.Fixed3D;
            listBox1.Items.Add("Investment: ");
            listBox1.Items.Add("Everyday: ");
            listBox1.Items.Add("Omni: ");
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }
        
        public void AddingAccount()
        {

            foreach (Accounts a in AllAccounts)
            {
                AccountByID.Add(a.ID, a);
            }

            Accounts account = AccountByID[100];
            MessageBox.Show(account.Info());
        }

        public void Deposit()
        {

        }

        public void Withdraw()
        {

        }

        public void Transfer()
        {

        }


        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            AddingAccount();

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit();

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw();

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transfer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Click += new EventHandler(ShowMessage);
            Controls.Add(b);

        }
        private void ShowMessage(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel transfer");
        }
    
    }
}
