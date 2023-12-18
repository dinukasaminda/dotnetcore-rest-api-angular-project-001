using PointOfSaleDataAccess;
using PointOfSaleSystem.Models.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Services.Invoices
{
    public class InvoiceService : IInvoiceRepository
    {
        private readonly POSDBContext _context = new();

        public Invoice CreateInvoice(Invoice invoice)
        {

            _context.Invoices.Add(invoice);
            _context.SaveChanges();

            return invoice;
        }

        public Invoice GetInvoiceById(int id)
        { 
             var invoice = _context.Invoices.Where(i => i.Id == id).FirstOrDefault();
            return invoice;
        }
    }
}
