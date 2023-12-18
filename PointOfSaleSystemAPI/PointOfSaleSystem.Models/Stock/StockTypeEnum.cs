namespace PointOfSaleSystem.Models.Stock
{
    public enum StockType
    {
        StockIn,
        StockOut,
    }
    public enum StockActionType
    {
        PurchaseByInvoice,
        SalesBill,
        ReturnBill,
    }
}