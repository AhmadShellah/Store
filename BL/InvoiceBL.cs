using DataBaseAccses.Invoice;
using Objects.Models.InvoiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class InvoiceBL
    {
        private readonly InvoiceRep _invoiceRep;

        public InvoiceBL()
        {
            _invoiceRep = new InvoiceRep();
        }


        public InvoiceModel Create(InvoiceModel inputFromUser)
        {
            var resultFromRepo = _invoiceRep.Create(inputFromUser);

            return resultFromRepo;
        }

        public List<InvoiceModel> GetAll()
        {
            var resultFromRepo = _invoiceRep.GetAll();

            foreach (var item in resultFromRepo)
            {
                item.Total = item.Products.Sum(c => c.Price);
            }

            return resultFromRepo;
            // var getAllProducts = resultFromRepo.SelectMany(x => x.Products);
        }
    }
}
