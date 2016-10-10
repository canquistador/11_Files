using System;
using System.Collections;

namespace _09_Portfolio
{

    internal class Stock : IAsset
    {
        public Stock(string v1, double v2, int v3)
        {
            Symbol = v1;
            PricePerShare = v2;
            NumShares = v3;
        }
        public Stock()
        {
        }

        public int NumShares
        {
            get;
            internal set;
        }
        public double PricePerShare
        {
            get;
            internal set;
        }
        public string Symbol
        {
            get;
            internal set;
        }

        public double GetValue()
        {
            return PricePerShare * NumShares;
        }

        internal static double TotalValue(IAsset[] stocks)
        {
            double returnme = 0;
            for (int i = 0; i < stocks.Length; i++)
            {
                returnme += stocks[i].GetValue();
            }
            
            return returnme;
        }
        public override string ToString()
        {
            return "Stock[symbol=" + Symbol.ToString() + "," +
                   "pricePerShare=" + PricePerShare.ToString().Replace(",",".") + "," +
                   "numShares=" + NumShares.ToString() + "]";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }   
        public override bool Equals(object obj)
        {
            Stock _obj = (Stock)obj;
            if (_obj.Symbol != Symbol || _obj.PricePerShare != PricePerShare || _obj.NumShares != NumShares)
                return false;
            else
                return true;
        }

        public string GetName()
        {
            return Symbol;
        }
        public long Id { get; set; }

    }
}