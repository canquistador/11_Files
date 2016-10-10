using System;
using _09_Portfolio;
using System.Collections.Generic;

namespace _09_Portfolio
{
    public class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset v1, IAsset v2)
        {
            return v2.GetValue().CompareTo(v1.GetValue());
        }
    }
}