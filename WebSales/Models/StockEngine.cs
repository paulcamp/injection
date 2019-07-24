using System.Collections.Generic;
using System.Linq;

namespace WebSales.Models
{
    public class StockEngine : IStockEngine
    {
        List<StockData> _stock = new List<StockData>();
        public StockEngine()
        {
            _stock.Add(new StockData() { Cost = 0.99M, Description = "testdata1", Sku = 1 });
            _stock.Add(new StockData() { Cost = 0.91M, Description = "testdata2", Sku = 2 });
            _stock.Add(new StockData() { Cost = 0.93M, Description = "testdata3", Sku = 3 });
            _stock.Add(new StockData() { Cost = 0.94M, Description = "testdata4", Sku = 4 });
            _stock.Add(new StockData() { Cost = 0.95M, Description = "testdata5", Sku = 5 });
        }
        public void DeductStock(int sku)
        {
            //_stock.FirstOrDefault(_ => _.Sku == sku).
        }

        public decimal LookupCost(int sku)
        {
            return _stock.FirstOrDefault(_ => _.Sku == sku).Cost;
        }

        public StockData LookupItem(int sku)
        {
            return _stock.FirstOrDefault(_ => _.Sku == sku);
        }
    }
}