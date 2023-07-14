using EFWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EFWebAPI.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<HeroiBatalha> HeroiBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VDKR8R6\\SQLEXPRESS;Database=Heroi; Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>()
                .HasKey(p => new { p.BatalhaId, p.HeroiId });
        }

    }
}
