using FasKes.Domain.Entity.R;
using Microsoft.EntityFrameworkCore;

namespace FasKes.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<RPendidikan1> RPendidikan1 { get; set; }
        public DbSet<RPendidikan2> RPendidikan2 { get; set; }
        public DbSet<RPendidikan3> RPendidikan3 { get; set; }

        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<RPendidikan1>().HasKey(m => m.Kode);
        //     builder.Entity<RPendidikan2>().HasKey(m => m.Kode);
        //     builder.Entity<RPendidikan3>().HasKey(m => m.Kode);
        // }
    }
}