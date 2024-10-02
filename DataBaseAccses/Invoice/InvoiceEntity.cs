using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccses.Invoice
{
    //DataBase Model
    public class InvoiceEntity : BaseEntity
    {
        public string PersonName { get; set; }

        public int Number { get; set; }

        public DateTime DueDate { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
