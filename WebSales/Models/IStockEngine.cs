namespace WebSales.Models
{
    public interface IStockEngine
    {
        void DeductStock(int sku);
        decimal LookupCost(int sku);
        StockData LookupItem(int sku);
    }
}