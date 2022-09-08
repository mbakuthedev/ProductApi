using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mbakuProductApi.Models
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {


        }
        public DbSet<Products> products { get; set; } = null!;

    }
}
