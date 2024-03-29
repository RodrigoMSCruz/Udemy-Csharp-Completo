using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 10.Exemplo.01.Entities
{
    public class BussinesAccount : Account
    {
        public double LoanLimit { get; set;}
    }

    public BussinesAccount()
    {

    }

    public BussinesAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
    {
        loanLimit = loanLimit;
    }

    public void Loan(double amount)
    {
        if (amount <= LoanLimit)
        {
            Balance += amount;
        }
        
    }

}