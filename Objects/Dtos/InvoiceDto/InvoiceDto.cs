using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Dtos.InvoiceDto
{
    public class InvoiceDto : BaseEntityDto
    {
        public string PersonName { get; set; }

        public int Number { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Total { get; set; }
    }
}
