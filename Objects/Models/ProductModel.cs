using Objects.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Models
{
    public class ProductModel : BaseEntityDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string? Description { get; set; }

        public string Photo { get; set; }
    }
}
