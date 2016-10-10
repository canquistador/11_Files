using System.Collections;

namespace _09_Portfolio
{
    internal interface IStockRepository
    {
        long NextId();
        void SaveStock(Stock yhoo);
        Stock LoadStock(long id);
        ICollection FindAllStocks();
        void Clear();
    }
}