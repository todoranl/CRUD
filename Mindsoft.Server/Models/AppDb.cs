using Microsoft.EntityFrameworkCore;

namespace Mindsoft.Server.Models
{
    public class AppDb : DbContext
{
        public AppDb(DbContextOptions<AppDb> options) : base(options)
        {
        }

        // DbSet-uri pentru modelele tale
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Persoana> Persoane { get; set; }
        public DbSet<Masina> Masini { get; set; }
    }
}
