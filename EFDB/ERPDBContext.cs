using EFDB.Entities;
using Microsoft.EntityFrameworkCore;
    
namespace EFDB
{
    public class ERPDBContext : DbContext
    {
        public ERPDBContext(DbContextOptions<ERPDBContext> options) : base(options)
        {

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<FacturaProveedor> FacturasProveedor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Role>().ToTable("Rol");
            modelBuilder.Entity<User>().ToTable("Usuario");

            modelBuilder.Entity<Proveedor>().ToTable("Proveedor");
            modelBuilder.Entity<FacturaProveedor>().ToTable("FacturaProveedor");
        }

    }
}