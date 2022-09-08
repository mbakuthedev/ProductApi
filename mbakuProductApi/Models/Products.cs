using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mbakuProductApi
{
    public class Products
    {
        [Key]
        public Guid ProductId { get; set; }
        public string  ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public byte[] ProductImage { get; set; }
        public DateTimeOffset TimeCreated { get; set; }
    }
}
