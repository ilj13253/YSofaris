using Microsoft.EntityFrameworkCore;
using SOFARI;

namespace SofariDb
{
    public class SOFARIDB : DbContext
    {
        public SOFARIDB(DbContextOptions<SOFARIDB> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }  
        public DbSet<ProductImg> ProductImgs { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<WhishList> WhishLists { get; set; }
        //public DbSet<Order> Orders { get; set; }
    }
}
