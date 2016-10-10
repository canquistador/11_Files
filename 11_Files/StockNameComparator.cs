using System;
using _09_Portfolio;
using System.Collections.Generic;

namespace _09_Portfolio
{
    public class StockNameComparator : IComparer<IAsset>
    {
        public int Compare(IAsset v1, IAsset v2)
        {
            return v1.GetName().CompareTo(v2.GetName());
        }
    }
}