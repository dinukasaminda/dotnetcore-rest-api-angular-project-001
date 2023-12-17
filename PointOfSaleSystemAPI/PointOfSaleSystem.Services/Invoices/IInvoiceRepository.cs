using PointOfSaleSystem.Models.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Services.Invoices
{
    public interface IInvoiceRepository
    {
        public InvoiceEntity CreateInvoice(InvoiceEntity invoice);
        public InvoiceEntity GetInvoiceById(int id);
    }
}
