using System;
using Assessment3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assessment3
{
    public class Accounts
    {
        private string account;
        private static int accountID = 1;
        private int iD;

        public string Account { get => account; set => account = value; }
        public int ID { get => iD; set => iD = value; }

        public Accounts() 
        {
            ID = accountID;
            accountID++;
        }

        public Accounts(string newAccount): this() 
        {
            account = newAccount;
        }
        public virtual string Info()
        {
            return ID + " " + Account;
        }
        public override string ToString()
        {
            return Account;
        }
    }

    public class Investment : Accounts 
    { 
        private int numinvAcc;

        public Investment(string newinvAccount) : base() { }

        public Investment(string newinvAccount, int accinvNum) : this(newinvAccount)
        { 
            NuminvAcc = accinvNum;
        }

        public int NuminvAcc { get => numinvAcc; set => numinvAcc = value; }

        public override string Info()
        {
            return base.Info() + " " + NuminvAcc + " Investment Account";

        }
    }

    public class Everyday : Accounts
    {
        private int numedayAcc;

        public Everyday(string newedayAccount) : base() { }

        public Everyday(string newedayAccount, int accedayNum) : this(newedayAccount) 
        {
            NumedayAcc = accedayNum;
        }

        public int NumedayAcc { get => numedayAcc; set => numedayAcc = value; }

        public override string Info()
        {
            return base.Info() + " " + NumedayAcc + " Everyday Account";

        }
    }

    public class Omni : Accounts
    {
        private int numomniAcc;

        public Omni(string newomniAccount) : base() { }

        public Omni(string newomniAccount, int accomniNum) : this(newomniAccount)
        {
            NumomniAcc = accomniNum;
        }

        public int NumomniAcc { get => numomniAcc; set => numomniAcc = value; }

        public override string Info()
        {
            return base.Info() + " " + NumomniAcc + " Omni Account";

        }

    }
}
