using static InnovaTasksByLucaFerretti.Core.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using static InnovaTasksByLucaFerretti.Core.Models.Models.Clienti;

namespace InnovaTasksByLucaFerretti.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Clienti> Clienti { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Prodotti> Prodotti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\luca_\\source\\repos\\InnovaTasksByLucaFerretti\\innova_db.db");
        }
    }
}
