using System;
using _09_Portfolio;
using System.Collections;
using System.Collections.Generic;
namespace _09_Portfolio
{
    internal class MemoryStockRepository : IStockRepository
    {
        public MemoryStockRepository ()
        {
            Id = 0;
        }
        List<Stock> ItemList = new List<Stock>();
        
        public void SaveStock(Stock items)
        {
            ItemList.Add(items);
        }
        public Stock LoadStock(long id)
        {
            return ItemList[(int) Id];
        }
        public long NextId()
        {
            return ++Id;
        }

        public ICollection FindAllStocks()
        {
            return ItemList;            
        }
        public void Clear()
        {
            ItemList.Clear();
        }
        public long Id { get; set; }

    }

}