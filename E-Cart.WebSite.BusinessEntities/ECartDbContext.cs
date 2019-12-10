using Microsoft.EntityFrameworkCore;
using E_Cart.WebSite.CoreEntities;

namespace E_Cart.WebSite.BusinessEntities

{
    public class ECartDbContext : DbContext
    {

        public ECartDbContext(DbContextOptions<ECartDbContext> options) : base(options)
        {
            //var siteSettings = this.GetInfrastructure().GetRequiredService<IOptionsSnapshot<SiteSettings>>();
        }

        public ECartDbContext()
        { }

        public DbSet<Products> Products { get; set; }
        public DbSet<Sellers> Sellers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<SellerAccounts> SellerAccounts { get; set; }
        public DbSet<Shipments> Shipments { get; set; }
        public DbSet<Users> Users { get; set; }


    }
}
