using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_WinFormsApp1
{
    internal class Account
    {
        private int _id;
        private string _name;
        private decimal _Balance;

        private bool _IdAlreadySet;

        public static int MinBal = 500;

        public Account()  // default constractor
        {
        }

        public Account(int Id, string Name, decimal balance) // parametraized constructor
        {
            this.id = Id;
            this.name = Name;
            this._Balance = balance;
        }

        public Account(Account a) 
            :this(a.id,a.name,a.Balance)  // copy constructor
        {

        }


        // Id Should create only once
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_IdAlreadySet)
                    throw new ApplicationException("Id already set");
                _id = value;
                _IdAlreadySet = true;
            }
        }

        // Set Balance as a Read only Property
        public decimal Balance
        {

            get
            {

                return _Balance;
            }
            private set
            {
                Balance = value;
            }
        }
        //Name lenght only 3 charecters
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 4)
                    throw new ApplicationException("Length of name 3 only");

                _name = value;
            }
        }
        public void Deposite(decimal Amount)
        {
            this._Balance += Amount;

        }
        public void Withdraw(decimal Amount)
        {
            if (this._Balance - Amount < MinBal)
            {
                throw new ApplicationException("insuficent funds");
            }
            else
            {
                this._Balance -= Amount;
            }
        }


    }

}
