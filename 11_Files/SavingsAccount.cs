using System;

namespace _09_Portfolio
{
    public class SavingsAccount : IAsset
    {

        public SavingsAccount(string v1, double v2, double v3)
        {
            savingsAccount = v1;
            Value = v2;
            InterestRate = v3;
        }
        public double Value
        {
            get;
            internal set;
        }
        public double InterestRate
        {
            get;
            internal set;
        }
        public string savingsAccount
        {
            get;
            internal set;
        }
        public override string ToString()
        {
            return "SavingsAccount[value=" + Value.ToString().Replace(",",".") + ".0," +
                   "interestRate=" + InterestRate.ToString().Replace(",", ".") + "]";
        }
        public double GetValue()
        {
            return Value;
        }
        public double ApplyInterest()
        {
            return Value += Value * (InterestRate/100);
        }
        public string GetName()
        {
            return savingsAccount;
        }

    }
}