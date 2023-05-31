using Gara.Models;
using Microsoft.EntityFrameworkCore;
namespace Gara
{
    public class AppDbContex:DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options) { 
        
        
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service_Customer>().HasKey(am => new
            {
                am.ServiceId,
                am.CustomerId
            });
            modelBuilder.Entity<Service_Customer>().HasOne(m => m.Service).WithMany(am => am.Service_Customers).HasForeignKey(m => m.ServiceId);

            modelBuilder.Entity<Service_Customer>().HasOne(m => m.Customer).WithMany(am => am.Service_Customers).HasForeignKey(m => m.CustomerId);
            base.OnModelCreating(modelBuilder);    
        }
    }
}
