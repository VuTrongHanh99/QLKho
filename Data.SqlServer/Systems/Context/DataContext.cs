using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SqlServer.Systems
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        #region
        public DbSet<Unit_DonViTinh>? Units { get; set; }
        public DbSet<Customer_KhachHang>? Customers { get; set; }
        public DbSet<Object_DoiTuong>? Objects { get; set; }
        public DbSet<Suplier_NhaCungCap>? Supliers { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Book>().HasData(
            //    new Book { Id = 1, Name = "Coupe", Title = "1", Description = "1", Price = 1000, Quantity = 10 }
            //);
        }
    }
}
