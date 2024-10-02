using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Models.InvoiceModels
{
    public class InvoiceModel
    {
        public Guid Id { get; set; }

        public string PersonName { get; set; }

        public int Number { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Total { get; set; }

        public List<ProductModel> Products { get; set; }
    }
}
