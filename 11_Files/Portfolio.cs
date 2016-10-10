using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        List<IAsset> items;
        public Portfolio (List<IAsset> items)
        {
            this.items = items;
        }
        public Portfolio ()
        {
            items = new List<IAsset>();
        }
        internal double GetTotalValue()
        {
            double returnme = 0;
            foreach (IAsset item in items)
            {
                returnme += item.GetValue();
            }
            return returnme;
        }
        internal void AddAsset(IAsset item)
        {
            items.Add(item);
        }
        internal List<IAsset> GetAssets()
        {
            return items;
        }


        internal IAsset GetAssetByName(string name)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (name == items[i].GetName())
                {
                    return items[i];
                }
            }
            return null;
        }

        internal IList<IAsset> GetAssetsSortedByName()
        {
            items.Sort(new StockNameComparator());
            return items;
        }
        internal IList<IAsset> GetAssetsSortedByValue()
        {
            items.Sort(new StockValueComparator());
            return items;
        }
    }
}