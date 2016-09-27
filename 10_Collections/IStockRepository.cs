using System.Collections;

namespace _10_Collections
{
    internal interface IStockRepository
    {
        void SaveStock(Stock yhoo);
        Stock LoadStock(int id);
        ICollection FindAllStocks();
        long NextId();
        Stock LoadStock(long id);
        
        void Clear();
    }
}