using PointOfSaleSystem.Models.Invoice;

namespace PointOfSaleSystem.Services.Invoices
{
    public interface IInvoiceRepository
    {
        public Invoice CreateInvoice(Invoice invoice);
        public Invoice GetInvoiceById(int id);
    }
}
